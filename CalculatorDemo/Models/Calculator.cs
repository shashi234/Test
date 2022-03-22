using System.ComponentModel.DataAnnotations;

namespace CalculatorDemo.Models
{

    public class Calculator
    {        
        public int Id { get; set; }
        public string ValueA { get; set; }
        public string ValueB { get; set; }
        public string Function { get; set; }
        public string Expected { get; set; }
        public string Actual { get; set; }
        public string Loggerinfo { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime Operationtime { get; set; }
    }
}
