using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TP_LW5.Models
{
    public class Person
    {
        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Фамилия")]
        public string LastName { get; set; }

        [DisplayName("Возраст")]
        public int Age { get; set; }

        [DisplayName("Стаж")]
        public int Experience { get; set; }

        [DisplayName("Специальность")]
        public string Specialization { get; set; }

        [DisplayName("Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
