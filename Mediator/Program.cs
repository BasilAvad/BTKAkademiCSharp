using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Mediator //Arabulucu Desen Görevi farklı sistemlerin birbirile görüştürme üstlenmesidir
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

          
            Teacher basil = new Teacher(mediator);
            basil.Name = "BASİL";
            mediator.teacher = basil;

            Student asil = new Student(mediator);
            asil.Name = "asil ";
            //mediator.Students.Add(student1);

            Student Ahmed = new Student(mediator);
            Ahmed.Name = "Ahmed ";
            //mediator.Students.Add(student2);

            Student khalid = new Student(mediator);
            khalid.Name = "khalid ";
            mediator.Students = new List<Student> { asil, Ahmed, khalid };

            basil.SendNewImageUrl("slideijpg");
            
            basil.RecieveQuestion("is it ture",khalid );
Console.ReadLine();
        }
    }
  abstract  class CourseMember
    {
       protected Mediator Mediator;

        protected CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
    class Teacher : CourseMember
    {
        public string Name { get; internal set; }
        public Teacher( Mediator mediator) : base(mediator)
        {

        }

        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine(" Teacher reciever a question from {0 } ,{1}",student.Name,question);
        }
        public void SendNewImageUrl(string url)
        {
            Console.WriteLine("Teacher changed slide :{0} ",url);
            Mediator.UpdateImage(url);
        }

        public void NswerQuestion(string answer,Student student)
        {
            Console.WriteLine("Teacher answered a question {0},{1} ",student.Name,answer);
        }
    }
    class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {

        }
        public string Name { get; internal set; }

        public void RecieveImage(string url)
        {
            Console.WriteLine("{1} syudent recieve image : {0}",url,Name);
        }

        public void RecieveAnswer(string answer)
        {
            Console.WriteLine(" student recieve aswer{0} ",answer);
        }
    }
    class Mediator // her şey bunun uzerinden kontrol edilyor 
    {
        public Teacher teacher { get; set; }
        public List<Student> Students { get; set; }
        public void UpdateImage(string url)
        {
            foreach (var student in Students)
            {
                student.RecieveImage(url);
            }
        }
        public void SendAnswer(string answer, Student student) // ogretmen cevab versin 
        {
            student.RecieveAnswer(answer);
        }
        public void SendQuestion(string question , Student student)
        {
            teacher.RecieveQuestion(question,student);
        }
    }
}
