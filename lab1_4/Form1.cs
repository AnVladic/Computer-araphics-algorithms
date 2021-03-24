using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;
using Tao.DevIl;

namespace lab
{
    public partial class Form1 : Form
    {
        double x = -8, y = 0, z = -30, a = 120, zoom = 1;
        int os_x = 1, os_y = 1, os_z = 1, d = 1, n = 4, m = 5;
        bool wire = false;
        int up = 0, down = 0, left = 0, right = 0;
        int xold = -15, yold = -6;

        //@@@

        // имя текстуры
        public string texture_name = "";
        // индефекатор текстуры
        public int imageId = 0;

        // текстурный объект
        public uint mGlTextureObject1 = 0;
        public uint mGlTextureObject2 = 0;
        public uint mGlTextureObject3 = 0;
        //@@@

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);

            // инициализация библиотеки openIL
            Il.ilInit();
            Il.ilEnable(Il.IL_ORIGIN_SET);

            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            xtrackBar_Scroll(null, null);
            ytrackBar_Scroll(null, null);
            ztrackBar_Scroll(null, null);
            angletrackBar_Scroll(null, null);
            zoomtrackBar_Scroll(null, null);

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            checkBox1.Checked = true;

            d = (int)d_numericUpDown.Value;
            n = (int)n_numericUpDown.Value;
            m = (int)m_numericUpDown.Value;

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Textures/";
            mGlTextureObject1 = loadTexture(projectDirectory + "текстура_для_яблока.jpg");
            mGlTextureObject2 = loadTexture(projectDirectory + "текстура_для_ножки.png");
            mGlTextureObject3 = loadTexture(projectDirectory + "текстура_для_листика.png");

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            if (useTextures.Checked)
                DrawApple2();
            else
                DrawApple();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { wire = true; }
            else
            { wire = false; }
        }

        private void Draw()
        {
            int i, j;
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();

            Gl.glPushMatrix();
            Gl.glTranslated(x, y, z);
            Gl.glRotated(a, os_x, os_y, os_z);
            Gl.glScaled(zoom, zoom, zoom);

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        if (wire)
                            Glut.glutWireSphere(2, 16, 16);
                        else
                            Glut.glutSolidSphere(2, 16, 16);
                        break;
                    }

                case 2:
                    {
                        if (wire)
                            Glut.glutWireCube(2);
                        else
                            Glut.glutSolidCube(2);
                        break;
                    }

                case 5:
                    {
                        if (wire)
                        {
                            //d = 2;
                            for (i = 1; i <= n; i++)
                            {
                                Gl.glTranslated(d, (-d * m), 0);
                                for (j = 1; j <= m; j++)
                                {
                                    Glut.glutWireCube(d);
                                    Gl.glTranslated(0, d, 0);

                                }
                            }



                        }
                        else
                            Glut.glutSolidCube(2);
                        break;
                    }

            }


            AnT.Invalidate();
        }

        private void DrawApple()
        {

            float[] color1 = new float[4] { 1, 0, 0, 1 };
            float[] color2 = new float[4] { 0, 0, 0, 1 };
            float[] color3 = new float[4] { 0, 1, 0, 1 };
            float[] shininess = new float[1] { 30 };
            /*if (wire)
            {

                Gl.glTranslated(xold, yold, -d);
                Gl.glTranslated(left * d - right * d, up * d - down * d, 0);
                Glut.glutWireSphere(d / 2, 16, 16);
                Gl.glTranslated(0, 0, -d);
                Glut.glutWireCylinder((double)(d * 0.05), (double)(d * 0.7), 8, 8);
                Gl.glTranslated(0, -d * 0.5, d * 0.3);
                Gl.glRotated(0, 0, 1, 0);
                Glut.glutWireCylinder((double)(d * 0.7), (double)(d * 0.1), 4, 1);
                xold = xold + left * d - right * d;
                yold = yold + up * d - down * d;


            }
            else 
             */
            {
                Gl.glTranslated(xold, yold, -d);
                Gl.glTranslated(left * d - right * d, up * d - down * d, 0);

                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, color1);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, color1);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, shininess);

                Glut.glutSolidSphere(d / 2, 16, 16);
                Gl.glTranslated(0, 0, -d);

                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, color2);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, color2);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, shininess);

                Glut.glutSolidCylinder((double)(d * 0.05), (double)(d * 0.7), 8, 8);
                Gl.glTranslated(0, -d * 0.5, d * 0.3);
                Gl.glRotated(30, 0, 1, 0);

                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, color3);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, color3);
                Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, shininess);

                Glut.glutSolidCylinder((double)(d * 0.5), (double)(d * 0.1), 4, 1);
                xold = xold + left * d - right * d;
                yold = yold + up * d - down * d;

            }
        }

        private void DrawApple2()
        {    //if (textureIsLoad)      
            {
                Glu.GLUquadric quadr1, quadr2, quadr3;

                // сохраняем состояние матрицы
                Gl.glPushMatrix();

                Gl.glTranslated(xold, yold, -d);
                Gl.glTranslated(left * d - right * d, up * d - down * d, 0);


                //Отрисовка сферы с текстурой:
                quadr1 = Glu.gluNewQuadric();
                Glu.gluQuadricTexture(quadr1, Gl.GL_TRUE);
                // включаем режим текстурирования
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                // включаем режим текстурирования , указывая индификатор mGlTextureObject
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject1);
                Glu.gluSphere(quadr1, d / 2, 32, 32);
                Glu.gluDeleteQuadric(quadr1);
                // отключаем режим текстурирования
                Gl.glDisable(Gl.GL_TEXTURE_2D);

                Gl.glTranslated(0, 0, -d);

                quadr2 = Glu.gluNewQuadric();
                Glu.gluQuadricTexture(quadr2, Gl.GL_TRUE);
                // включаем режим текстурирования
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject2);

                Glu.gluCylinder(quadr2, (double)(d * 0.05), (double)(d * 0.03), (double)(d * 0.7), 8, 8);
                Glu.gluDeleteQuadric(quadr2);
                // отключаем режим текстурирования
                Gl.glDisable(Gl.GL_TEXTURE_2D);

                Gl.glTranslated(d * 0.1, -d * 0.1, d * 0.3);
                Gl.glRotated(30, 0, 1, 0);

                //quadr3 = Glu.gluNewQuadric();
                //Glu.gluQuadricTexture(quadr3, Gl.GL_TRUE);
                // включаем режим текстурирования
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, mGlTextureObject3);

                // отрисовываем полигон
                Gl.glBegin(Gl.GL_POLYGON);
                // указываем поочередно вершины и текстурные координаты
                Gl.glVertex3d((double)(d * 0.7), (double)(d * 0.7), 0);
                Gl.glTexCoord2f(0.0f, 0.0f);
                Gl.glVertex3d((double)(d * 0.7), (double)(d * 0.4), 0);
                Gl.glTexCoord2f(0.7f, 0.0f);
                Gl.glVertex3d((double)(d * -0.2), (double)(d * 0.0), 0);
                Gl.glTexCoord2f(1.0f, 1.0f);
                Gl.glVertex3d((double)(d * -0.1), (double)(d * 0.4), 0);
                Gl.glTexCoord2f(0.0f, 1.0f);
                // завершаем отрисовку
                Gl.glEnd();

                //Glu.gluCylinder(quadr3, (double)(d * 0.5), (double)(d * 0.0), (double)(d * 0.1), 4, 2);
                // отключаем режим текстурирования
                Gl.glDisable(Gl.GL_TEXTURE_2D);



                /*
                // отрисовываем полигон
                Gl.glBegin(Gl.GL_POLYGON);

                // указываем поочередно вершины и текстурные координаты
                Gl.glVertex3d((double)(d * 0.9), (double)(d * 0.9), 0);
                //Gl.glTexCoord2f(0.0f, 0.0f);
                Gl.glTexCoord2f(0.1f, 0.7f);
                Gl.glVertex3d((double)(d * 0.8), (double)(d * 0.5), 0);
                //Gl.glTexCoord2f(0.4f, 0.4f);
                Gl.glTexCoord2f(0.0f, 0.0f);
                Gl.glVertex3d((double)(d * 0.2),0, 0);
                //Gl.glTexCoord2f(0.9f, 0.3f);
                Gl.glTexCoord2f(0.4f, 0.4f);
                Gl.glVertex3d((double)(d * -0.2),0, 0);
                //Gl.glTexCoord2f(1.0f, 0.7f);
                Gl.glTexCoord2f(0.9f, 0.3f);
                Gl.glVertex3d((double)(d * -0.1), (double)(d * 0.5), 0);
                //Gl.glTexCoord2f(0.7f, 1.0f);
                Gl.glTexCoord2f(1.0f, 0.7f);
                Gl.glVertex3d((double)(d * 0.2), (double)(d * 0.7), 0);
                //Gl.glTexCoord2f(0.1f, 0.7f);
                Gl.glTexCoord2f(0.7f, 1.0f);

                // завершаем отрисовку
                Gl.glEnd();
                 */
                //Glu.gluDeleteQuadric(quadr3);

                xold = xold + left * d - right * d;
                yold = yold + up * d - down * d;

                // возвращаем матрицу
                Gl.glPopMatrix();

            }
            AnT.Invalidate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        os_x = 1;
                        os_y = 0;
                        os_z = 0;
                        break;
                    }
                case 1:
                    {
                        os_x = 0;
                        os_y = 1;
                        os_z = 0;
                        break;
                    }
                case 2:
                    {
                        os_x = 0;
                        os_y = 0;
                        os_z = 1;
                        break;
                    }
            }
        }

        private void xtrackBar_Scroll(object sender, EventArgs e)
        {
            x = (double)xtrackBar.Value;
            xlabel.Text = "x= " + x.ToString();
        }

        private void ytrackBar_Scroll(object sender, EventArgs e)
        {
            y = (double)ytrackBar.Value;
            ylabel.Text = "y= " + y.ToString();
        }

        private void ztrackBar_Scroll(object sender, EventArgs e)
        {
            z = (double)ztrackBar.Value;
            zlabel.Text = "z= " + z.ToString();
        }

        private void angletrackBar_Scroll(object sender, EventArgs e)
        {
            a = (double)angletrackBar.Value;
            anglelabel.Text = "angle= " + a.ToString();
        }

        private void zoomtrackBar_Scroll(object sender, EventArgs e)
        {
            zoom = (double)zoomtrackBar.Value;
            zoomlabel.Text = "zoom= " + zoom.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = (int)d_numericUpDown.Value;
            n = (int)n_numericUpDown.Value;
            m = (int)m_numericUpDown.Value;

        }

        private void up_button_Click(object sender, EventArgs e)
        {
            up = 0; down = 1; left = 0; right = 0;

        }

        private void down_button_Click(object sender, EventArgs e)
        {
            up = 1; down = 0; left = 0; right = 0;
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            up = 0; down = 0; left = 0; right = 1;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            up = 0; down = 0; left = 1; right = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            up = 0; down = 0; left = 0; right = 0;
        }

        private uint loadTexture(string url)
        {
            // создаем изображение с индификатором imageId
            Il.ilGenImages(1, out imageId);
            // делаем изображение текущим
            Il.ilBindImage(imageId);

            uint texture = 0;

            // пробуем загрузить изображение
            if (Il.ilLoadImage(url))
            {
                // если загрузка прошла успешно
                // сохраняем размеры изображения
                int width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
                int height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);

                // определяем число бит на пиксель
                int bitspp = Il.ilGetInteger(Il.IL_IMAGE_BITS_PER_PIXEL);

                switch (bitspp) // в зависимости оп полученного результата
                {
                    // создаем текстуру используя режим GL_RGB или GL_RGBA
                    case 24:
                        texture = MakeGlTexture(Gl.GL_RGB, Il.ilGetData(), width, height);
                        break;
                    case 32:
                        texture = MakeGlTexture(Gl.GL_RGBA, Il.ilGetData(), width, height);
                        break;
                }
            }
            // очищаем память
            Il.ilDeleteImages(1, ref imageId);
            return texture;
        }

        // создание текстуры в памяти openGL static 
        private uint MakeGlTexture(int Format, IntPtr pixels, int w, int h)
        {
            // индетефекатор текстурного объекта
            uint texObject;

            // генерируем текстурный объект
            Gl.glGenTextures(1, out texObject);

            // устанавливаем режим упаковки пикселей
            Gl.glPixelStorei(Gl.GL_UNPACK_ALIGNMENT, 1);

            // создаем привязку к только что созданной текстуре
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texObject);

            // устанавливаем режим фильтрации и повторения текстуры
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_S, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_WRAP_T, Gl.GL_REPEAT);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
            Gl.glTexEnvf(Gl.GL_TEXTURE_ENV, Gl.GL_TEXTURE_ENV_MODE, Gl.GL_REPLACE);

            // создаем RGB или RGBA текстуру
            switch (Format)
            {
                case Gl.GL_RGB:
                    {
                        Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB, w, h, 0, Gl.GL_RGB, Gl.GL_UNSIGNED_BYTE, pixels);
                        break;
                    }

                case Gl.GL_RGBA:
                    {
                        Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGBA, w, h, 0, Gl.GL_RGBA, Gl.GL_UNSIGNED_BYTE, pixels);
                        break;
                    }
            }

            // возвращаем индетефекатор текстурного объекта

            return texObject;
        }

    }
}
