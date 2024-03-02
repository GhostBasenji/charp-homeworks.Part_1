// Программа отображает координаты курсора мыши относительно экрана и
// элемента управления. Программа заполняет список ListBox данными о
// местоположении и изменении положения курсора мыши. Кроме того, 
// в текстовых полях отображаются координаты положения курсора мыши
// относительно экрана и элемента управления ListBox
namespace HW_014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Мониторинг движения мыши";
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            // Прцедура обработки события, когда указатель мыши входит
            // в видимую часть элемента управления ListBox:
            // ~ ~ ~ ~ ~ ~ ~
            // Добавляем в список элементов новую запись
            listBox1.Items.Add("Курсор мыши вошел в область ListBox");

        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            // Прцедура обработки события, когда указатель мыши покидает
            // видимую часть элемента управления ListBox:
            listBox1.Items.Add("Курсор мыши вышел из области ListBox");
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Процедура обработки события, происходящего при перемещении
            // указателя мыши на элементе управления ListBox:
            // ~ ~ ~ ~ ~ ~ ~ ~ 
            // Свойство объекта Control MousePosition возвращает точку,
            // соответствующую текущему положению мыши относительно
            // левого верхнего угла монитора

            textBox1.Text = String.Format("X = {0} или {1}",
                Control.MousePosition.X, e.X);
            textBox2.Text = String.Format("Y = {0} или {1}",
                Control.MousePosition.Y, e.Y);
            //  Здесь мы получаем координаты положения курсора мыши в системе координат экрана, когда начало координат
            //  расположено в левом верхнем углу экрана, ось х направлена вправо, а ось y — вниз

            // Заметим, что аргументы события мыши e также содержат в себе текущие координаты
            // курсора мыши, но в системе координат элемента управления, в данном случае listBox1.
            // Начало координат этой системы расположено в левом верхнем углу элемента управления listBox1, ось х также направлена вправо, ось y — вниз.
            // Эти координаты получаем из аргументов события e.X и e.Y и выводим их в текстовое поле, отделяя от предыдущих координат словом "или".

        }
    }
}


// В этой программе нам понадобится обработать событие загрузки формы, а также три события, относящиеся к объекту ListBox1.
// Получить пустой обработчик события загрузки формы весьма просто — надо только двойным щелчком щелкнуть на проектируемой форме.
// А чтобы получить три соответствующих пустых обработчика для объекта ListBox1, следует в конструкторе формы в панели свойств (Properties)
// щелкнуть на пиктограмме молнии и в открывшемся списке возможных событий для объекта ListBox1 выбрать следующие три события: MouseEnter, MouseLeave и MouseMove.