using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;


namespace lab2
{
    class Point
    {
        public float x, y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Shape
    {
        public Point offset, scale;
        public Point[] points;

        public Shape(Point[] points, Point offset, Point scale)
        {
            this.offset = offset;
            this.scale = scale;
            this.points = points;
        }

        public void Draw()
        {
            Gl.glBegin(Gl.GL_LINE_LOOP);
            foreach (Point point in points)
                Gl.glVertex2d(point.x * scale.x + offset.x, point.y * scale.y + offset.y);
            Gl.glEnd();
        }
    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void AnT_Load(object sender, EventArgs e)
        {
            // инициализация Glut
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_SINGLE);
            // очистка окна
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода в соответствии с размерами элемента anT
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            // настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            // теперь необходимо корректно настроить 2D ортогональную проекцию
            // в зависимости от того, какая сторона больше
            // мы немного варьируем то, как будет сконфигурированный настройки проекции
            if ((float)AnT.Width <= (float)AnT.Height)
            {
                Glu.gluOrtho2D(0.0, 30 * (float)AnT.Height / (float)AnT.Width, 0.0, 30.0);
            }
            else
            {
                Glu.gluOrtho2D(0.0, 30 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);
            }
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // очищаем буфер цвета
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            // очищаем текущую матрицу
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - красный
            Gl.glColor3f(255, 0, 0);
            // активируем режим рисования линий, на основе

            Point scale = new Point(2, 2);
            Point offset = new Point(2, 10);
            int step = 12;

            // A
            Shape shape = new Shape(new Point[]
            {
                new Point(0, 0),
                new Point(2.5f, 5),
                new Point(5, 0),
                new Point(4, 0),
                new Point(3.5f, 1),
                new Point(1.5f, 1),
                new Point(1, 0),
            }, offset, scale);
            shape.Draw();
            shape.points = new Point[]
            {
                new Point(2, 2),
                new Point(2.5f, 3),
                new Point(3, 2),
            };
            shape.Draw();

            // B
            shape.offset.x += step;
            shape.points = new Point[]
            {
                new Point(0, 0),
                new Point(0, 5),
                new Point(5, 5),
                new Point(5, 3),
                new Point(3, 2.5f),
                new Point(5, 2),
                new Point(5, 0),
            };
            shape.Draw();
            shape.points = new Point[]
            {
                new Point(1, 1),
                new Point(1, 2),
                new Point(2, 2),
                new Point(4, 1.5f),
                new Point(4, 1),
            };
            shape.Draw();
            shape.points = new Point[]
            {
                new Point(1, 3),
                new Point(1, 4),
                new Point(4, 4),
                new Point(4, 3.5f),
                new Point(2, 3),
            };
            shape.Draw();

            // Д
            shape.offset.x += step;
            shape.points = new Point[]
            {
                new Point(0, 0),
                new Point(0, 2),
                new Point(1, 2),
                new Point(2, 5),
                new Point(3, 5),
                new Point(4, 2),
                new Point(5, 2),
                new Point(5, 0),
                new Point(4, 0),
                new Point(4, 1),
                new Point(1, 1),
                new Point(1, 0),
            };
            shape.Draw();
            shape.points = new Point[]
            {
                new Point(2, 2),
                new Point(2.5f, 4),
                new Point(3, 2),
            };
            shape.Draw();

            // дожидаемся конца визуализации кадра
            Gl.glFlush();
            // посылаем сигнал перерисовки элемента AnT.
            AnT.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
