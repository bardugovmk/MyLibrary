using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Media;

namespace MyLibrary.MVVM.View.TableView
{
    public partial class AuthorsTableView : UserControl
    {
        public class Member
        {
            public string Number { get; set; }
            public string Path { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string MiddleName { get; set; }
            public string Biography { get; set; }
        }
        public AuthorsTableView()
        {
            InitializeComponent();

            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { Number = "1", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Lem.png",  Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "Имя Станислава Лема хорошо знакомо любителям фантастики...." });
            members.Add(new Member { Number = "2", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Булгаков.png", Name = "Михаил", Surname = "Булгаков", MiddleName = "Афанасьевич", Biography = "Русский писатель советского периода, врач   ...." });
            members.Add(new Member { Number = "3", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Гоголь.png", Name = "Николай", Surname = "Гоголь", MiddleName = "Васильевич", Biography = "Русский прозаик, драматург, критик, публицист, признанный...." });
            members.Add(new Member { Number = "4", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Горький.png", Name = "Максим", Surname = "Горький", MiddleName = "Макси́мович    ", Biography = "Русский советский писатель, поэт, прозаик...." });
            members.Add(new Member { Number = "5", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Достоевский.png", Name = "Фёдор ", Surname = "Достоевский", MiddleName = "Михайлович", Biography = "Русский писатель, мыслитель, философ и публицист...." });
            members.Add(new Member { Number = "6", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Лермонтов.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "7", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Пушкин.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "8", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Толстой.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "9", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Тургеньев.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "10", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Чехов.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });

            members.Add(new Member { Number = "11", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Lem.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "Имя Станислава Лема хорошо знакомо любителям фантастики...." });
            members.Add(new Member { Number = "12", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Булгаков.png", Name = "Михаил", Surname = "Булгаков", MiddleName = "Афанасьевич", Biography = "Русский писатель советского периода, врач   ...." });
            members.Add(new Member { Number = "13", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Гоголь.png", Name = "Николай", Surname = "Гоголь", MiddleName = "Васильевич", Biography = "Русский прозаик, драматург, критик, публицист, признанный...." });
            members.Add(new Member { Number = "14", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Горький.png", Name = "Максим", Surname = "Горький", MiddleName = "Макси́мович    ", Biography = "Русский советский писатель, поэт, прозаик...." });
            members.Add(new Member { Number = "15", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Достоевский.png", Name = "Фёдор ", Surname = "Достоевский", MiddleName = "Михайлович", Biography = "Русский писатель, мыслитель, философ и публицист...." });
            members.Add(new Member { Number = "16", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Лермонтов.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "17", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Пушкин.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "18", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Толстой.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "19", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Тургеньев.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "20", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Чехов.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });

            members.Add(new Member { Number = "21", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Lem.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "Имя Станислава Лема хорошо знакомо любителям фантастики...." });
            members.Add(new Member { Number = "22", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Булгаков.png", Name = "Михаил", Surname = "Булгаков", MiddleName = "Афанасьевич", Biography = "Русский писатель советского периода, врач   ...." });
            members.Add(new Member { Number = "23", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Гоголь.png", Name = "Николай", Surname = "Гоголь", MiddleName = "Васильевич", Biography = "Русский прозаик, драматург, критик, публицист, признанный...." });
            members.Add(new Member { Number = "24", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Горький.png", Name = "Максим", Surname = "Горький", MiddleName = "Макси́мович    ", Biography = "Русский советский писатель, поэт, прозаик...." });
            members.Add(new Member { Number = "25", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Достоевский.png", Name = "Фёдор ", Surname = "Достоевский", MiddleName = "Михайлович", Biography = "Русский писатель, мыслитель, философ и публицист...." });
            members.Add(new Member { Number = "26", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Лермонтов.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "27", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Пушкин.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "28", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Толстой.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "29", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Тургеньев.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });
            members.Add(new Member { Number = "30", Path = "D:\\ProgramCSharp\\GitHub\\MyLibrary\\MyLibrary\\Resources\\tmp\\Чехов.png", Name = "Станислав", Surname = "Лем", MiddleName = "Герман", Biography = "...." });

            Authors.ItemsSource = members;
        }
    }
}
