using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Form myForm = new Form();
            
        }
    }

    //Mediator 
    class Form
    {
        private Button button;
        private TextBox textBox;
        private ListBox listBox;

        public Form()
        {
            Initializer();
        }

        private void Initializer()
        {
            button = new Button(this);
            textBox = new TextBox(this);
            listBox = new ListBox(this);
            button.OnButtonClick += OnButtonClick;
            textBox.OnTextBoxChanged += OnTextBoxChanged;
        }

        public void OnButtonClick()
        {
            listBox.Items.Add(textBox.Text);
        }

        public void OnTextBoxChanged()
        {
            button.Enabled = true;
        }
    }

    abstract class Component
    {
        protected Form form;
        public Component(Form form)
        {
            this.form = form;
        }
    }

    class Button : Component
    {
        public bool Enabled { get; set; } = false;
        public event Action OnButtonClick;
        public Button(Form form) : base(form) { }
        public void ButtonClick()
        {
            if (Enabled)
            {
                OnButtonClick?.Invoke();
            }
        }
    }

    class TextBox : Component
    {
        public TextBox(Form form) : base(form) { }
        public event Action OnTextBoxChanged;
        public string Text { get; set; }
        public void TextBoxChanged()
        {
            OnTextBoxChanged?.Invoke();
        }
    }

    class ListBox : Component
    {
        public ListBox(Form form) : base(form) { }
        public List<string> Items { get; private set; }
    }
}
