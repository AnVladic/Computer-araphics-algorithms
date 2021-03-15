using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;

namespace lab
{
    public partial class Form1 : Form
    {
        // вспомогательные переменные - в них будут храниться обработанные значения,
        // полученные при перетаскивании ползунков пользователем
        double a = 0, b = 0, c = -5, d = 0, zoom = 1; // выбранные оси
        int os_x = 1, os_y = 0, os_z = 0;

        // режим сеточной визуализации
        bool Wire = false;

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки glut
            Glut.glutInit();
            // инициализация режима экрана
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            // установка цвета очистки экрана (RGBA)
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            // активация проекционной матрицы
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очистка матрицы
            Gl.glLoadIdentity();
            // установка перспективы
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света)
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            // установка первых элементов в списках combobox
            comboBox1.SelectedIndex = 0;
            // активация таймера, вызывающего функцию для визуализации
            RenderTimer.Start();
        }

        // обрабатываем отклик таймера
        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            // вызываем функцию отрисовки сцены
            Draw();
        }

        // событие изменения значения
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат
            a = (double)trackBar1.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком
            label4.Text = a.ToString();
        }

        // событие изменения значения
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат
            b = (double)trackBar2.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком
            label5.Text = b.ToString();
        }

        // событие изменения значения
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат
            c = (double)trackBar3.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком
            label6.Text = c.ToString();
        }

        // событие изменения значения
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат
            d = (double)trackBar4.Value;
            // подписываем это значение в label элементе под данным ползунком
            label7.Text = d.ToString();
        }

        // событие изменения значения
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            // переводим значение, установившееся в элементе trackBar в необходимый нам формат
            zoom = (double)trackBar5.Value / 1000.0;
            // подписываем это значение в label элементе под данным ползунком
            label9.Text = zoom.ToString();
        }

        // изменения значения чекбокса
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // если отмечен
            if (checkBox1.Checked)
            {
                // устанавливаем сеточный режим визуализации
                Wire = true;
            }
            else
            {
                // иначе - полигональная визуализация
                Wire = false;
            }
        }

        // изменение в элементах comboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // в зависимости от выбранного режима
            switch (comboBox1.SelectedIndex)
            {
                // устанавливаем необходимую ось (будет использована в функции glRotate**)
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

        private void DrawCube(float size)
        {
            if (Wire) // если установлен сеточный режим визуализации
                Glut.glutWireCube(size);
            else
                Glut.glutSolidCube(size);
        }

        private void DrawSphere(float radius)
        {
            if (Wire) // если установлен сеточный режим визуализации
                Glut.glutWireSphere(radius, 16, 16); // сеточная сфера
            else
                Glut.glutSolidSphere(radius, 16, 16); // полигональная сфера
        }

        private void DrawCylinder(float radius, float height)
        {
            if (Wire) // если установлен сеточный режим визуализации
                Glut.glutWireCylinder(radius, height, 16, 16); // цилиндр
            else
                Glut.glutSolidCylinder(radius, height, 16, 16);
        }

        private void DrawCone(float radius, float height)
        {
            if (Wire) // если установлен сеточный режим визуализации
                Glut.glutWireCone(radius, height, 32, 32); // конус
            else
                Glut.glutSolidCone(radius, height, 32, 32);
        }


        private void DrawAntennae(float scale=1)
        {
            Gl.glPushMatrix();

            Gl.glRotated(-90, 1, 0, 0);
            DrawCylinder(scale * 0.1f, scale * 2);

            Gl.glRotated(90, 1, 0, 0);
            Gl.glTranslated(0, scale * 2, 0);
            DrawSphere(scale * 0.15f);

            Gl.glPopMatrix();
        }


        // функция отрисовки
        private void Draw()
        {
            // очистка буфера цвета и буфера глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            // очищение текущей матрицы
            Gl.glLoadIdentity();

            Gl.glPushMatrix();
            Gl.glRotated(d, os_x, os_y, os_z);
            Gl.glTranslated(a, b, c);
            Gl.glScaled(zoom, zoom, zoom);



            // Раковина
            Gl.glPushMatrix();
            Gl.glTranslated(1, 0.5f, 0);
            DrawSphere(1f);
            Gl.glPopMatrix();



            // Тело
            Gl.glPushMatrix();
            Gl.glTranslated(1, -0.1, 0);
            Gl.glRotated(-90, 0, 1, 0);
            DrawCylinder(0.4f, 2f);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslated(1.5, -0.1, 0);
            Gl.glRotated(90, 0, 1, -0.55f);
            DrawCone(0.4f, 0.8f);
            Gl.glPopMatrix();



            // Голова
            Gl.glPushMatrix();
            Gl.glTranslated(-1, -0.1, 0);
            DrawSphere(0.4f);
            Gl.glPopMatrix();



            //Усики
            Gl.glPushMatrix();
            Gl.glTranslated(-1, 0.1, 0.2);
            Gl.glRotated(45, 0, 0.5, 1);
            DrawAntennae(0.5f);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslated(-1, 0.1, -0.2);
            Gl.glRotated(45, 0, -0.5, 1);
            Gl.glScaled(0.5, 0.5, 0.5);
            DrawAntennae();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslated(-1, -0.2, 0.2);
            Gl.glRotated(120, 0, 0.5, 1);
            DrawAntennae(0.2f);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslated(-1, -0.2, -0.2);
            Gl.glRotated(120, 0, -0.5, 1);
            DrawAntennae(0.2f);
            Gl.glPopMatrix();


            //  Цилиндр
            Gl.glPushMatrix();
            Gl.glTranslated(-0.9, 0.32, 0);
            Gl.glRotated(90, 1, 0, 0);
            DrawCylinder(0.3f, 0.05f);
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslated(-0.9, 0.3, 0);
            Gl.glRotated(-90, 1, 0, 0);
            DrawCylinder(0.25f, 0.4f);
            Gl.glPopMatrix();


            Gl.glPopMatrix();
            // завершаем рисование
            Gl.glFlush();
            // обновляем элемент AnT
            AnT.Invalidate();
        }
    }
}
