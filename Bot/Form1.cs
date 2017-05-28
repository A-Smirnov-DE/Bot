using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stencil firefoxIcon = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\mozilla-firefox.png");
            firefoxIcon.mouseClick();
            
            /*
            Stencil piImage = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\pi.png");

            if (piImage.mouseMove(new Rectangle(1300, 20, 100, 100)))
            {
                richTextBox1.Text += Environment.NewLine + "Ура!!! Картинка найдена!!!";
            }
            else
            {
                richTextBox1.Text += Environment.NewLine + "Картинка не найдена!!!";
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            YouTube.switchGermanLanguage();

            YouTube.login(@richTextBox1);

            System.Threading.Thread.Sleep(10000);
            */

            YouTube.chooseChannel("C:\\Users\\desjatnik\\Documents\\tests\\Vera-Kanal.png");

            YouTube.searchForNoneSeenVideo(@richTextBox1);

            /*
            YouTube.logout();
            */
        }
    } // class Form1

    public class YouTube
    {
        private static Color seenVideoLineColor = System.Drawing.Color.FromArgb(255, 230, 33, 23);

        /*
        public enum KEYEVENT
        {
            KEYDOWN = 0x0001, //Key down flag
            KEYUP = 0x0002, //Key up flag
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        */

        public static Boolean chooseChannel(String str)
        {
            Stencil channelIcon = new Stencil(str);
            if (channelIcon.mouseClick())
            {
                return chooseVideoTab();
            }

            return false;
        } // chooseChannel()

        public static Boolean chooseVideoTab()
        {
            Stencil videoLink = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\Video-Link-ru.png");
            Boolean result = videoLink.mouseClick();
            System.Threading.Thread.Sleep(2000);
            return result;
        } // chooseVideoTab()

        public static Boolean login(RichTextBox textBox)
        {
            Stencil loginButton = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\login-ru.png");
            textBox.Text += Environment.NewLine + "Ищу кнопку Вход";
            loginButton.mouseClick();

            switchGermanLanguage();

            Stencil switchAccountLink = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\switch-account-link-ru.png");
            textBox.Text += Environment.NewLine + "Ищу кнопку Войти в другой аккаунт";
            if (switchAccountLink.mouseClick())
            {
                Stencil deleteLink = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\delete-link-ru.png");
                textBox.Text += Environment.NewLine + "Ищу кнопку 1";
                deleteLink.mouseClick();

                Stencil crossLink = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\cross-link.png");
                textBox.Text += Environment.NewLine + "Ищу крестик";
                crossLink.mouseClick();

                Stencil readyLink = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\ready-link-ru.png");
                textBox.Text += Environment.NewLine + "Ищу кнопку готово";
                readyLink.mouseClick();
            }

            Stencil enterEmail = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\enter-email.png");
            textBox.Text += Environment.NewLine + "Ищу кнопку 4";
            enterEmail.mouseClick();

            myBot.printString("Your.Best.Jeweler@gmail.com");


            /*
            keybd_event((byte)Keys.Q, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.Q, 0, (int)KEYEVENT.KEYUP, 0);

            keybd_event((byte)Keys.E, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.E, 0, (int)KEYEVENT.KEYUP, 0);

            keybd_event((byte)Keys.M, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.M, 0, (int)KEYEVENT.KEYUP, 0);

            keybd_event((byte)Keys.RMenu, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.Q, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.Q, 0, (int)KEYEVENT.KEYUP, 0);
            keybd_event((byte)Keys.RMenu, 0, (int)KEYEVENT.KEYDOWN | (int)KEYEVENT.KEYUP, 0);

            keybd_event((byte)Keys.Q, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.Q, 0, (int)KEYEVENT.KEYUP, 0);

            keybd_event((byte)Keys.E, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.E, 0, (int)KEYEVENT.KEYUP, 0);

            keybd_event((byte)Keys.M, 0, (int)KEYEVENT.KEYDOWN, 0);
            keybd_event((byte)Keys.M, 0, (int)KEYEVENT.KEYUP, 0);
            */


            Stencil nextButtom = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\next-buttom-ru.png");
            textBox.Text += Environment.NewLine + "Ищу кнопку 5";
            nextButtom.mouseClick();

            Stencil passwordInputField = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\password-ru.png");
            textBox.Text += Environment.NewLine + "Ищу поле введения пароля";
            if (passwordInputField.mouseClick())
            { // Если нашли поле воода пароля, то вводим пароль. :)
                myBot.printString("yaq123456");
            } // if()


            Stencil loginButton2 = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\login-buttom2-ru.png");
            textBox.Text += Environment.NewLine + "Ищу кнопку Вход вновь";
            loginButton2.mouseClick();

            return true;
        } // login()

        public static Boolean logout()
        {
            Stencil wwwURL = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\www-url.png");
            wwwURL.mouseClick();

            myBot.printString("www.youtube.com/logout" + Environment.NewLine);


            return true;
        } // logout()

        public static Boolean switchGermanLanguage()
        {
            Stencil winRuIcon = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\win-ru-icon.png");
            if (winRuIcon.mouseClick())
            {
                Stencil deutschDeutschland = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\deutsch-deutschland.png");
                return deutschDeutschland.mouseClick();
            } // if

            return false;
        } // switchGermanLanguage()

        public static Boolean searchForNoneSeenVideo(RichTextBox textBox)
        {
            int delta = 46;

            Stencil videoLink = new Stencil("C:\\Users\\desjatnik\\Documents\\tests\\views-ru.png");
            Rectangle videoRect = videoLink.searchRect();

            videoRect.Height += delta;
            videoRect.Y -= delta;

            textBox.Text += Environment.NewLine + videoRect.ToString();

            if (myBot.getColor(videoRect.Location) == seenVideoLineColor)
            {
                Rectangle videoRectRight = videoRect;
                videoRectRight.X     = videoRectRight.Right;
                videoRectRight.Width = Screen.PrimaryScreen.Bounds.Width - videoRectRight.X;

                if (videoRectRight.Width > 0)
                {
                    videoRect = videoLink.searchRectInRect(videoRectRight);
                } // if()
            } // if()
            
            textBox.Text += Environment.NewLine + videoRect.ToString();

            myBot.moveCursor(videoRect.Location);

            System.Threading.Thread.Sleep(2000);

            return true;
        } // searchForNoneSeenVideo()
    } // class YouTube

    public class Stencil
    {
        private Bitmap image;

        public Stencil(String path)
        {
            loadSmallImage(path);
        }

        public Bitmap getImage()
        {
            return this.image;
        } // getImage()

        public Rectangle searchRect()
        {
            myBot thisBot = new myBot();
            return thisBot.imageSearchRect(this.image);
        } // imageSearchRect()

        public Boolean isFound()
        {
            myBot thisBot = new myBot();
            return thisBot.imageSearch(this.image);
        } // isFound()

        public Rectangle searchRectInRect(Rectangle area)
        {
            myBot thisBot = new myBot(area);
            return thisBot.imageSearchRect(this.image);
        } // imageSearchRect()

        public Boolean isFoundInRect(Rectangle rect)
        {
            myBot thisBot = new myBot(rect);
            return thisBot.imageSearch(this.image);
        } // isFoundInRect()

        /**
         * Поиск шаблона на всём экране.
         */
        public Boolean mouseMove()
        {
            myBot thisBot = new myBot();
            return thisBot.imageSearchAndMouseMove(this.image);
        } // imageSearchRect()

        public Boolean mouseClick()
        {
            myBot thisBot = new myBot();
            return thisBot.imageSearchAndMouseClick(this.image);
        } // mouseClick()

        /**
         * Поиск шаблона в определённой области.
         */
        public Boolean mouseMove(Rectangle area)
        {
            myBot thisBot = new myBot(area);
            return thisBot.imageSearchAndMouseMove(this.image);
        } // imageSearchRect()

        private Bitmap loadSmallImage(String path)
        {
            // Create a Bitmap object from an image file.
            Bitmap image = new Bitmap(path);
            this.image = image;
            return image;
        }
    } // class Stencil

    public class myBot
    {
        private static Bitmap screenShot;

        private Rectangle area;

        [Flags]

        public enum MOUSEEVENTF
        {
            MOVE = 0x01,
            LEFTDOWN = 0x02,
            LEFTUP = 0x04,
            RIGHTDOWN = 0x08,
            RIGHTUP = 0x10,
            ABSOLUTE = 0x8000
        }

        public enum KEYEVENT
        {
            KEYDOWN = 0x0001, //Key down flag
            KEYUP   = 0x0002, //Key up flag
        }
        
        /*
        public enum KEYCODE
        {
            Point = 0x2e, // Точка

            A = 0x41, //A key code
            B = 0x42, //B key code
            C = 0x43, //C key code

            a = 0x61, //a key code
            b = 0x62,
            c = 0x63,

            VK_LCONTROL = 0xA2, //Left Control key code
        }
        */

        /*
http://www.kbdedit.com/manual/low_level_vk_list.html

https://msdn.microsoft.com/de-de/library/aa243025(v=VS.60).aspx

https://msdn.microsoft.com/en-us/library/windows/desktop/dd375731(v=vs.85).aspx
        */

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, IntPtr dwExtraInfo);

        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern uint MapVirtualKey(uint uCode, uint uMapType);

        public myBot()
        {
            this.create_screen_shot();
        }

        public myBot(Rectangle area)
        {
            this.area = area;
            this.create_screen_shot();
        }

//        private Bitmap create_screen_shot(int sourceX = 0, int sourceY = 0)
        private Bitmap create_screen_shot()
        {
            int imageWidth, imageHeight, sourceX, sourceY;
            Graphics graph = null;

            if (!this.area.IsEmpty)
            {   // Ищем картинку только в определённом регионе
                imageWidth  = this.area.Width;
                imageHeight = this.area.Height;

                sourceX = this.area.X;
                sourceY = this.area.Y;
            }
            else
            {   // Ищем картинку на всём экране
                imageWidth  = Screen.PrimaryScreen.Bounds.Width;
                imageHeight = Screen.PrimaryScreen.Bounds.Height;

                sourceX = 0;
                sourceY = 0;
            }

            var bmp = new Bitmap(imageWidth, imageHeight);

            graph = Graphics.FromImage(bmp);
            graph.CopyFromScreen(sourceX, sourceY, 0, 0, bmp.Size);

            screenShot = bmp;

            bmp.Save("C:\\Users\\desjatnik\\Documents\\tests\\screen.bmp");
            return bmp;
        } // create_screen_shot()

        private Boolean screenShotSubSearch(Bitmap smallImage, Point screenShotPoint)
        { // Стартовые координаты на большом скриншоте
            int xPositionStartPoint = screenShotPoint.X;
            int yPositionStartPoint = screenShotPoint.Y;

            // Идём по маленькой картинке
            for (int yPosition = 0; yPosition < smallImage.Height; yPosition++)
            { // Прогон маленькой картинки по оси y (Столбики)
                for (int xPosition = 0; xPosition < smallImage.Width; xPosition++)
                { // Прогон маленькой картинки по оси x (Строчки)

                    if (!smallImage.GetPixel(xPosition, yPosition).Equals(
                         screenShot.GetPixel(xPosition + xPositionStartPoint, yPosition + yPositionStartPoint)))
                    {
                        return false;
                    } // if
                } // for
            } // for

            return true;
        } // screenShotSubSearch()

        public Boolean imageSearch(Bitmap smallImage)
        {
            Rectangle rec = imageSearchRect(smallImage);

            if (!rec.IsEmpty)
            {
                // Картинка была найдена
                return true;
            }

            return false;
        } // imageSearch()

        public Boolean imageSearchAndMouseMove(Bitmap smallImage)
        {
            Rectangle rec = imageSearchRect(smallImage);

            if (!rec.IsEmpty)
            { // Картинка была найдена
                if (!this.area.IsEmpty)
                { 
                    rec.Offset(this.area.Location);
                }
                moveCursor(rec);

                return true;
            }

            return false;
        } // imageSearchAndMouseMove()

        public Boolean imageSearchAndMouseClick(Bitmap smallImage)
        {
            Rectangle rec = imageSearchRect(smallImage);

            if (!rec.IsEmpty)
            { // Картинка была найдена
                if (!this.area.IsEmpty)
                {
                    rec.Offset(this.area.Location);
                }
                mouseClick(rec);

                return true;
            }

            return false;
        } // 

        public Rectangle imageSearchRect(Bitmap smallImage)
        {
            Color smallImageFirstPixelColor = smallImage.GetPixel(0, 0);

            Color screenShotPixelColor = new Color();
            // Ищем до совпадения по первому пикселю, потом переходим в подпрограмму.
            for (int yPosition = 0; yPosition < screenShot.Height - smallImage.Height; yPosition++)
            { // Прогон большой картинки по оси y (Столбики)
                for (int xPosition = 0; xPosition < screenShot.Width - smallImage.Width; xPosition++)
                { // Прогон большой картинки по оси x (Строчки)

                    screenShotPixelColor = screenShot.GetPixel(xPosition, yPosition);


                    if (screenShotPixelColor.Equals(smallImageFirstPixelColor))
                    { // пиксель сошёлся


                        Point firstPoint = new Point(xPosition, yPosition);

                        if (screenShotSubSearch(smallImage, firstPoint))
                        { // Ура!!! Картинку нашли!!!
                            return new Rectangle(firstPoint, new Size(smallImage.Width, smallImage.Height));
                        } // if Картинку нашли!!!
                    } // if пиксель сошёлся

                } // строчки
            } // столбики

            return new Rectangle();
        } // imageSearchRect()

        public static Color getColor(int xPosition, int yPosition)
        {
            /*
            if (!area.IsEmpty)
            { // Поправка на тот случай, если поиск делался не по всему экрану, а только в части.
                xPosition += area.X;
                yPosition += area.Y;
            } // if
            */

            return screenShot.GetPixel(xPosition, yPosition);
        } // getColor()

        public static Color getColor(Point p)
        {
            return getColor(p.X, p.Y);
        } // getColor()

        public static void moveCursor(Point p)
        {
            System.Windows.Forms.Cursor Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = p;
        } // moveCursor(Point p)

        public static void moveCursor(int x, int y)
        {
            moveCursor(new Point(x, y));
        } // MoveCursor(int x, int y)

        public static void moveCursor(Rectangle r)
        {

            Random rnd = new Random();
            moveCursor(
                new Point(
                    (int)rnd.Next(r.Left, r.Right),
                    (int)rnd.Next(r.Top, r.Bottom)));
        } // MoveCursor(int x, int y)

        public static void mouseClick(Point p)
        {
            mouseClick(p.X, p.Y);
        } // mouseClick(Point p)

        public static void mouseClick(int x, int y)
        {
            moveCursor(x, y);
            
            //передвинули курсор
            //mouse_event((uint)MOUSEEVENTF.MOVE, 0, 0, 0, IntPtr.Zero);

            //нажали правую кнопку
            mouse_event((uint)MOUSEEVENTF.ABSOLUTE | (uint)MOUSEEVENTF.LEFTDOWN | (uint)MOUSEEVENTF.LEFTUP, 0, 0, 0, IntPtr.Zero);
            System.Threading.Thread.Sleep(2000);
        } //

        public static void mouseClick(Rectangle r)
        {
            Random rnd = new Random();
            mouseClick(
                new Point(
                    (int)rnd.Next(r.Left, r.Right),
                    (int)rnd.Next(r.Top, r.Bottom)));
        } // mouseClick(Rectangle r)

        public static void keyDown(byte bVk, byte key = 0)
        {
            uint scanCode;

            if (key == 0)
            {
                scanCode = 0;
            }
            else
            {
                scanCode = MapVirtualKey((uint)key, 0);
            }
            keybd_event(bVk, (byte)scanCode, (int)KEYEVENT.KEYDOWN, 0);
            
            Random rnd = new Random();
            System.Threading.Thread.Sleep((int)rnd.Next(120, 200));
        }

        public static void keyDown(Keys vKey, Keys sKey = 0)
        {
            keyDown((byte)vKey, (byte)sKey);
        }

        public static void keyUp(byte bVk, byte key = 0)
        {
            uint scanCode;

            if (key == 0)
            {
                scanCode = 0;
            }
            else
            {
                scanCode = MapVirtualKey((uint)key, 0);
            }

            if (bVk == (byte)Keys.RMenu || bVk == (byte)Keys.ShiftKey)
            {
                keybd_event(bVk, (byte)scanCode, (int)KEYEVENT.KEYDOWN | (int)KEYEVENT.KEYUP, 0);
            }
            else
            {
                keybd_event(bVk, (byte)scanCode, (int)KEYEVENT.KEYUP, 0);
            }
            
            Random rnd = new Random();
            System.Threading.Thread.Sleep((int)rnd.Next(120, 200));
        }

        public static void keyUp(Keys vKey, Keys sKey = 0)
        {
            keyUp((byte)vKey, (byte)sKey);
        }

        public static void printString(String s)
        { // В переменой s может быть следующие группы символов a-z, A-Z, @, /, 0-9, Shift, Ctrl, Win-Fn, Alt, Alt Gr и т.д.
            foreach (char cOrig in s)
            {
                Char c;
                Keys pressedKey = 0;
                Boolean pressedSHIFT = false, pressedCTRL = false, pressedALT = false, pressedALTGR = false;
                if ('a' <= cOrig && cOrig <= 'z')
                {   // маленькие буквы a-z
                    c = Char.ToUpper(cOrig);
                }
                else if ('A' <= cOrig && cOrig <= 'Z')
                {   // большие буквы A-Z (Shift + a-z)

                    keyDown(Keys.ShiftKey); // зажимаем Shift
                    pressedSHIFT = true;

                    c = cOrig;
                }
                else if ('.' == cOrig)
                {   // точка
                    c = (char)Keys.OemPeriod;
                }
                else if ('/' == cOrig)
                {   // точка
                    c = (char)Keys.Divide;
                }
                else if ('@' == cOrig)
                {   // символ @

                    pressedKey = Keys.RMenu;
                    keyDown(pressedKey, pressedKey); // зажимаем AltGr
                    pressedALTGR = true;

                    c = 'Q';
                }
                else
                {
                    c = cOrig;
                }

                byte b = (byte)c;
                byte bPressedKey = 0; // (byte)pressedKey;
                keyDown(b, bPressedKey);
                keyUp(b, bPressedKey);

                if (pressedALTGR)
                {
                    pressedKey = Keys.RMenu;
                    keyUp(pressedKey, pressedKey); // отжимаем AltGr
                    pressedKey = 0;
                    pressedALTGR = false;
                }

                if (pressedALT)
                {
                    keyUp(0x12); // отжимаем Alt
                    pressedALT = false;
                }

                if (pressedCTRL)
                {
                    keyUp(0x11); // отжимаем Ctrl
                    pressedCTRL = false;
                }

                if (pressedSHIFT)
                {
                    keyUp(Keys.ShiftKey); // отжимаем Shift
                    pressedSHIFT = false;
                }

            } // foreach
            
            System.Threading.Thread.Sleep(2000);
        }
    } // class myBot
}

/*
 * Ваш Ювелир
 * Your.Best.Jeweler@gmail.com
 * yaq123456
 * 29.01.1980
 * M
*/
