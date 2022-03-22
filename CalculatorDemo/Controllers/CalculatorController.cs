using Calculator;
using Microsoft.AspNetCore.Mvc;
using CalculatorDemo.Models;
using Microsoft.AspNetCore.Cors;

namespace CalculatorDemo.Controllers
{
    [ApiController]
    [Route("Calculator")]
    public class CalculatorController : Controller
    {
        ILogger<Calculate> logger;
        Calculate c;
        CalculatorDemo.Models.Calculator cal;
        private readonly DBCalculationsContext _context;

        public CalculatorController(DBCalculationsContext dBCalculationsContext)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(config =>
            {
                config.AddConsole();
            });

            logger = loggerFactory.CreateLogger<Calculate>();
            c = new Calculate(logger);
            _context=dBCalculationsContext;
            cal = new CalculatorDemo.Models.Calculator();            
        }

        [Route("Add")]
        [EnableCors("calculationsservice")]
        public int Add(int a, int b)
        {                                    
            int result = c.Add(a, b);
            
            cal.ValueA = a.ToString(); cal.ValueB = b.ToString(); cal.Expected=c.Add(a, b).ToString();cal.Function = "Addition";
            cal.Actual=result.ToString(); cal.Loggerinfo = $"Sum of {a} and {b} is {result}"; cal.Operationtime = DateTime.Now;

            _context.Calculations.Add(cal);
            _context.SaveChanges();
            logger.LogInformation($"Sum of {a} and {b} is {result}");
            return result;
        }

        [Route("Multiply")]
        [EnableCors("calculationsservice")]
        public int Multiply(int a, int b)
        {           
            int result = c.Multiply(a, b);
            
            cal.ValueA = a.ToString(); cal.ValueB = b.ToString(); cal.Expected = c.Add(a, b).ToString(); cal.Function = "Multiplication";
            cal.Actual = result.ToString(); cal.Loggerinfo = $"Mulplication of {a} and {b} is {result}"; cal.Operationtime = DateTime.Now;

            _context.Calculations.Add(cal);
            _context.SaveChanges();

            logger.LogInformation($"Mulplication of {a} and {b} is {result}");
            return result;
        }

        [Route("Substract")]
        [EnableCors("calculationsservice")]
        public int Substract(int a, int b)
        {            
            int result = c.Substract(a, b);

            cal.ValueA = a.ToString(); cal.ValueB = b.ToString(); cal.Expected = c.Add(a, b).ToString(); cal.Function = "Substraction";
            cal.Actual = result.ToString(); cal.Loggerinfo = $"Substraction of {a} and {b} is {result}"; cal.Operationtime = DateTime.Now;

            _context.Calculations.Add(cal);
            _context.SaveChanges();

            logger.LogInformation($"Substraction of {a} and {b} is {result}");
            return result;
        }

        [Route("Division")]
        [EnableCors("calculationsservice")]
        public float Divide(int a, int b)
        {            
            float result = c.Divide(a, b);

            cal.ValueA = a.ToString(); cal.ValueB = b.ToString(); cal.Expected = c.Add(a, b).ToString(); cal.Function = "Division";
            cal.Actual = result.ToString(); cal.Loggerinfo = $"Division of {a} and {b} is {result}"; cal.Operationtime = DateTime.Now;

            _context.Calculations.Add(cal);
            _context.SaveChanges();

            logger.LogInformation($"Division of {a} and {b} is {result}");
            return result;
        }
        [Route("Prime")]
        [EnableCors("calculationsservice")]
        public int Getprimenumber(int a)
        {
            int n, i, flag = 0, c = 1;

            if (a == 1)
            {
                return 2;
            }

            for (n = 3; n > 2; n++)
            {
                for (i = 2; i < n; i++)
                {
                    if (n != i && n % i == 0)
                    {
                        break;
                    }
                    else if (i > n / 2)
                    {
                        c++;
                        if (c == a) { return n; }
                        break;
                    }

                }
            }
            return 0;
        }
    }
}
