using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services
{
    public class StringInterpolationService : IStringInterpolationService
    {
        private readonly ISystemDate _date;
        private readonly ILogger<IStringInterpolationService> _logger;
        private const double Pi = Math.PI;
        public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
        {
            _date = date;
            _logger = logger;
            _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
        }

        //1. January 22, 2019 (right aligned in a 40 character field)
        public string Number01()
        {
            var date = _date.Now.ToString("MMMM dd, yyyy");
            var answer = $"{date,40}";
            Console.WriteLine(answer);

            return answer;
        }

        public string Number02()
        {
            var date = $"{_date.Now:yyyy}.{_date.Now:MM}.{_date.Now:dd}";
            Console.WriteLine(date);

            return date;
        }

        public string Number03()
        {
            var date = $"Day {_date.Now:dd} of {_date.Now:MMMM}, {_date.Now:yyyy}";
            Console.WriteLine(date);
            return date;
            
        }

        public string Number04()
        {
            var date = $"Year: {_date.Now:yyyy}, Month: {_date.Now:MM}, Day: {_date.Now:dd}";
            Console.WriteLine(date);
            return date;
        }

        public string Number05()
        {
            var date = $"{_date.Now,10:dddd}";
            Console.WriteLine(date);
            return date;
        }

        public string Number06()
        {
            var date = $"{_date.Now:hh}:{_date.Now:mm} {_date.Now:tt}";
            var addition = $"{date,10}";
            var final = addition + $"{_date.Now,10:dddd}";
            Console.WriteLine(final);
            return final;
        }

        public string Number07()
        {
            var date = $"h:{_date.Now:hh}, m:{_date.Now:mm}, s:{_date.Now:ss}";
            Console.WriteLine(date);
            return date;
        }

        public string Number08()
        {
            var date = $"{_date.Now:yyyy}.{_date.Now:MM}.{_date.Now:dd}.{_date.Now:hh}.{_date.Now:mm}.{_date.Now:ss}";
            Console.WriteLine(date);
            return date;
        }

        public string Number09()
        {
            var output = $"{Pi:C}";
            Console.WriteLine(output);
            return output;
        }

        public string Number10()
        {
            var output = $"{Pi,10:n3}";
            Console.WriteLine(output);
            return output;
        }

        public string Number11()
        {
            var initial = Math.Sqrt(2);
            return initial.ToString();
        }

        
        //2.2019.01.22
    }
}
