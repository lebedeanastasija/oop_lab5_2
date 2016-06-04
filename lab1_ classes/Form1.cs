using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPaintAPI;
using System.Reflection;
using lab1__classes.Lists;
using System.IO;
using FunctionPluginAPI;


namespace lab1__classes
{
    public partial class Figures : Form
    {
        private Point lastBtnFigurePosition = new Point(349, 215);
        private Point lastBtnPluginPosition = new Point(460, 100);

        Figure figure;
        ImageInfo imageInfo = new ImageInfo();
        FigureCreator figureCreator;
        FigureInitializer figureInitializer;
        FigureDrawer figureDrawer;

        DrawerList drawerList = new DrawerList();
        CreatorList creatorList = new CreatorList();
        InitializerList initializerList = new InitializerList();

        Pen pen;
        Graphics graphics;
        Graphics graphicsTemp;
        Bitmap bitmap;
        Bitmap bitmapTemp;

        PicturesList imageList = new PicturesList();
        BinSerializer binSerializer = new BinSerializer();
        int imagesCount = 50;
        int playImageNumber;

        byte[] writtenBytes = null;
        byte[] readedBytes = null;

        byte[] writtenHash = null;
        byte[] readedHash = null;

        IFunctionPlugin functionPlugin;
 
        public Figures()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 3);
            textBox1.BackColor = pen.Color;
            this.Controls.Add(canvas);
            bitmap = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            bitmapTemp = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            graphics = Graphics.FromImage(bitmap);
            graphicsTemp = Graphics.FromImage(bitmapTemp);
            canvas.Enabled = false;
            canvas.Image = bitmap;
        }

        private void btnFigure_Click(object sender, EventArgs e)
        {
         
            canvas.Enabled = true;           

            if (lsbPictures.Items.Count >= imagesCount)
            { 
                lsbPictures.Items.RemoveAt(0);
                imageList.RemoveAt(0);
            }
            
            figureCreator = creatorList[Convert.ToInt32((sender as Button).Tag.ToString())];
            figure = figureCreator.CreateFigure();
            figureDrawer = drawerList[Convert.ToInt32((sender as Button).Tag.ToString())];
            figureInitializer = initializerList[Convert.ToInt32((sender as Button).Tag.ToString())];
        }

        private void btnPlugin_Click(object sender, EventArgs e)
        {
            if (writtenBytes != null || readedBytes != null)
            {
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    using (FileStream fileStream = new FileStream(saveDialog.FileName, FileMode.OpenOrCreate))
                    {               
                        if (writtenBytes == null) 
                        { 
                            readedHash = functionPlugin.GetControlNumber(readedBytes);
                            fileStream.Write(readedHash, 0, readedHash.Length);
                        }
                        else
                        {
                            if (writtenHash == null)
                            {
                                writtenHash = functionPlugin.GetControlNumber(writtenBytes);
                                fileStream.Write(writtenHash, 0, writtenHash.Length);
                            }
                            else
                            {
                                readedHash = functionPlugin.GetControlNumber(readedBytes);
                                fileStream.Write(readedHash, 0, readedHash.Length);

                                if (!CompareArrays(writtenHash, readedHash))
                                {
                                    MessageBox.Show("The data in " + opnDialog.FileName + " was corrupted!");
                                }
                            }
                        }                    
                    }
                }
            }
            else
            {
                MessageBox.Show("You didn`t save or load image list yet. Save it and try again :)");
            }
        } 

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if ((figure.Base.X < 0) && (figure.Base.Y < 0))
            {               
                figure.Base = new Point(e.X, e.Y);                
            }
            else
            {
                graphics.DrawImage(bitmap, 0, 0);
                graphics.DrawImage(bitmapTemp, 0, 0);
                canvas.Image = bitmap;                

                Bitmap drawBitmap = new Bitmap(canvas.Image);
                MemoryStream ms = new MemoryStream();
                drawBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                imageInfo = new ImageInfo();
                imageInfo.Date = DateTime.Now;
                imageInfo.Image = new byte[ms.Position];
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(imageInfo.Image, 0, imageInfo.Image.Length);

                imageList.Add(imageInfo);
                lsbPictures.Items.Add(imageInfo.Date.ToString());

                figure.Base = new Point(-1, -1);
                
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if ((figure.Base.X >= 0) && (figure.Base.Y >= 0))
            {
                canvas.Image = bitmap;
          
                figureInitializer.InitializeFigure(figure, e.X, e.Y);       
                bitmapTemp = figureDrawer.DrawFigure(canvas, pen, figure);
                
                if(figure.Id == 0)
                    graphics.DrawImage(bitmapTemp, 0, 0);
                canvas.Image = bitmapTemp;
                canvas.Refresh();
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            dlgColor.ShowDialog();
            pen.Color = dlgColor.Color;
            textBox1.BackColor = pen.Color;
        }        

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen.Width = Convert.ToInt32(cmbWidth.SelectedItem.ToString());
        }

        private void btnAddPlugin_Click(object sender, EventArgs e)
        {
            string pluginName;
            string className;

            if(dlgPlugin.ShowDialog() != DialogResult.Cancel)
            {
                //Регистрируем плагин
                pluginName = dlgPlugin.FileName;
                className = GetNumespaceName(pluginName);                

                Assembly dll = Assembly.LoadFrom(pluginName);
                Type myClass = dll.GetType(className + "." + className);
                IPlugin plugin = (IPlugin) Activator.CreateInstance(myClass);
                plugin.Initialize(creatorList, drawerList, initializerList);

                //добавляем новую функциональность на форму
                Button btn = new Button();
                this.Controls.Add(btn);
                btn.Name = "btn" + plugin.GetPluginName();
                btn.Tag = creatorList.Count - 1;
                btn.Click += btnFigure_Click;
                btn.Width = 86;
                btn.Height = 32;
                lastBtnFigurePosition.Y += 35;
                btn.Location = lastBtnFigurePosition;
                btn.FlatStyle= FlatStyle.System;
                btn.Text = plugin.GetPluginName();
                btn.Visible = true;
                btn.Show();
            }          
        }       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                writtenBytes = binSerializer.SerializeImages(imageList, saveDialog.FileName);
            }           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            PicturesList list = new PicturesList();
            if (opnDialog.ShowDialog() == DialogResult.OK)
            {                
                list = binSerializer.DeserializeImages(opnDialog.FileName, ref readedBytes);
            }
            
            lsbPictures.Items.Clear();
            imageList.RemoveRange(0,imageList.Count);
            foreach (ImageInfo picture in list)
            {
                lsbPictures.Items.Add(picture.Date.ToString());
                imageList.Add(picture);
            }
        }

        private void lsbPictures_DoubleClick(object sender, EventArgs e)
        {
            ShowImage(lsbPictures.SelectedIndex);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.Text == "Play")
            {
                btnPlay.Text = "Stop";
                playImageNumber = 0;
                timer.Start();
            }
            else
            {
                btnPlay.Text = "Play";
                playImageNumber = 0;
                timer.Stop();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (playImageNumber < imageList.Count)
            {
                ShowImage(playImageNumber);
                playImageNumber++;
            }
            else
            {               
                playImageNumber = 0;
            }
        }        

        private void btnAddFunctionPlugin_Click(object sender, EventArgs e)
        {
            string pluginName;
            string className;

            if (dlgPlugin.ShowDialog() != DialogResult.Cancel)
            {
                //Регистрируем плагин
                pluginName = dlgPlugin.FileName;
                className = GetNumespaceName(pluginName);

                Assembly dll = Assembly.LoadFrom(pluginName);
                Type myClass = dll.GetType(className + "." + className);
                functionPlugin = (IFunctionPlugin)Activator.CreateInstance(myClass);

                //добавляем новую функциональность на форму
                Button btn = new Button();
                this.Controls.Add(btn);
                btn.Name = "btn" + functionPlugin.GetFunctionPluginName();
                btn.Tag = creatorList.Count - 1;
                btn.Click += btnPlugin_Click;
                btn.Width = 196;
                btn.Height = 23;
                lastBtnPluginPosition.Y += 29;
                btn.Location = lastBtnPluginPosition;
                btn.FlatStyle = FlatStyle.System;
                btn.Text = functionPlugin.GetFunctionPluginName();
                btn.Visible = true;
                btn.Show();
            }         
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int itemNumber = lsbPictures.SelectedIndex;
            if (itemNumber >= 0)
            {
                imageList.RemoveAt(itemNumber);
                lsbPictures.Items.RemoveAt(itemNumber);
            }
            else
            {
                MessageBox.Show("Select image, please.");
            }
        }   

        private void ShowImage(int number)
        {
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Capacity = 40000;
            memoryStream.Write(imageList[number].Image, 0, imageList[number].Image.Length);
            Image image = Bitmap.FromStream(memoryStream);
            canvas.Image = image;
        }

        private string GetNumespaceName(string plugin_name)
        {
            string[] directories = plugin_name.Split('\\');
            string dll = directories[directories.Length - 1];
            string[] temp = dll.Split('.');
            string numespaseName = temp[0];
            return numespaseName;
        }

        private bool CompareArrays(byte[] array1, byte[] array2)
        {
            bool result = true;
            if (array1.Length != array2.Length)
            {
                result = false;
            }               
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                        result = false;
                }
            }
            return result;
        }             
    }
}
