using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Customers.Concretes
{
    class Customer
    {
        #region Properties (Özellikler)

        public int Id  { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City  { get; set; }
        #endregion

        #region Fields (Alanlar)

        //string _name;
        //string _surname;
        int _age;
        #endregion

        #region Behaviors (Davranışlar)

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetSurname(string surname)
        //{
        //    _surname = surname;

        //}

        //public string Getsurname()
        //{
        //    return _surname;
        //}

        public void SetAge(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return _age;
        }
        #endregion
    }
}
