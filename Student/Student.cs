using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Student
    {
        private int ID;
        private string name;
        private string address;
        private int age;
        public Student()
        {

        }
        public Student(int _ID, string _name, string _address, int _age)
        {
            this.ID = _ID;
            this.name = _name;
            this.address = _address;
            this.age = _age;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetID(int _ID)
        {
            this.ID = _ID;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string _name)
        {
            this.name = _name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void SetAddress(string _address)
        {
            this.address = _address;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int _age)
        {
            this.age = _age;
        }
        public override string ToString()
        {
            return "ID: "+ID+" Name: "+name+" Address: "+address+" Age: "+age;
        }
    }
}
