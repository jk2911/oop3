using System;
using System.Collections.Generic;
using System.Text;

namespace laba_3
{
    class Student
    {
        private readonly int id = 0;
        private string name;//имя
        private string surname;//фамилия
        private string patronymic = "";//отчество
        private short birthday = 2002;//год рождения
        private string address = "";//адрес
        private int? telephone = null;//телефон
        private string faculty = "";//факультет
        private byte course = 1;//курс
        private byte group = 1;//группа
        private static int size = 0;
        public int ID
        {
            get { return this.id; }
        }
        public string NAME
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string SURNAME
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        public string PATRONYMIC
        {
            get { return this.patronymic; }
            set { this.patronymic = value; }
        }
        public short BIRTHDAY
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public string ADDRESS
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public int? TELEPHONE
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
        public string FACULTY
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        public byte COURSE
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public byte GROUP
        {
            get { return this.group; }
            set { this.group = value; }
        }
        public Student(string nm, string srnm, string fclt, byte gr)
        {
            this.id = MakeHash(birthday, size, gr);
            this.name = nm;
            this.surname = srnm;
            this.faculty = fclt;
            group = gr;
            size++;
        }
        public Student(string nm, string srnm, string ptrc, short birtd, string adrs, int tele, string fclt, byte curs, byte gr)
        {
            id = MakeHash(birtd, size, gr);
            name = nm;
            surname = srnm;
            patronymic = ptrc;
            birthday = birtd;
            address = adrs;
            telephone = tele;
            faculty = fclt;
            course = curs;
            group = gr;
            size++;
        }
        public Student(string nm, string srnm, string ptrc, short birtd, string fclt, byte curs, byte gr)
        {
            id = MakeHash(birtd, size, gr);
            name = nm;
            surname = srnm;
            patronymic = ptrc;
            birthday = birtd;
            faculty = fclt;
            course = curs;
            group = gr;
            size++;
        }
        private int MakeHash(int year, int size, int gr)
        {
            int hash = (year / 100) * 100000 + gr * 1000 + size;
            return hash;
        }
        public static void sizeinfo()
        {
            Console.WriteLine("Количество студентов: " + size);
        }
    }
}
