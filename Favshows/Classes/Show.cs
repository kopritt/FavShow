using System;
namespace Favshows
{
    public class Show: BaseEntity
    {
        //Atributes               
         private Gender Gender { get; set; } //Gender is an enum

        private string Title {get; set;}

        private string Description {get; set;}

        private int Year {get; set;}

        //Methods

        
        public Show(int id,Gender gender, string title, string description, int year) 
        {
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
               
        }

        public override string ToString()
        {
            //Enviroment NewLine it get how the OS take the line
            string  Return = "";
            Return += "Gender: " + this.Gender + Environment.NewLine;
            Return += "Title: " + this.Title + Environment.NewLine;
            Return += "Description: " + this.Description + Environment.NewLine;
            Return += "Release Year: " + this.Year + Environment.NewLine;
            return Return;

        }

        //Encapsulation

        public int getId()
        {
            return this.Id;
        }

        public string getTitle()
        {
            return this.Title;
        }
        



    }
}