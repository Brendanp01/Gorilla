using System;
using Gtk;
using Microsoft.ClearScript.V8;

namespace Gorilla
{
    class Program
    {

        public static void Main() {
            Application.Init();

             //Create the Window
            Window myWin = new Window("Gorilla");
            
            myWin.Resize(640,360);

            //Create a label and put some text in it.
            Label myLabel = new Label();
            myLabel.Text = "Hola";

            //Add the label to the form
            myWin.Add(myLabel);

            //Show Everything
            myWin.ShowAll();

            Application.Run();
        }
    }
}