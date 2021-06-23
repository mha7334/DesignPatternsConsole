using System.Collections.Generic;

namespace DesignPatternsConsole.Mediator1
{
    public class Form: IMediator
    {
        private readonly List<Colleague> colleagues = new List<Colleague>();

        public void AddColleague(Colleague c)
        {
            this.colleagues.Add(c);

        }
        public void Send(string @event, Colleague colleague)
        {
            foreach (var col in colleagues)
            {
                if(col !=  colleague)
                    col.HandleEvent(@event);
            }
        }
    }

    public class Tester
    {
        public static void Run(string[] args)
        {
            Form form = new Form();

            Button btn = new Button(form);
            TextBox textBox = new TextBox(form);
            DropDownMenu dropDown = new DropDownMenu(form);


            form.AddColleague(btn);
            form.AddColleague(textBox);
            form.AddColleague(dropDown);

            textBox.TriggerTextChanged("changed");

            //textBox.TriggerTextChanged("text changed ");

          
        }
    }
}