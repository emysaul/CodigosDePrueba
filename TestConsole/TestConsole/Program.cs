using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Net;
using System.Reflection;

namespace TestWebServices
{


    public class Program
    {

        public class WorkQueueSchedule
        {
            /// <summary>
            /// Days of the week from 1 to 7 (Monday to Sunday)
            /// </summary>
            public int Day { get; set; }
            public TimeSpan StartHour { get; set; }
            public TimeSpan EndHour { get; set; }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca (N) numeros deseados:  ");


            int n = Convert.ToInt32(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduzca siguiente numero: ");
                int newNumber = Convert.ToInt32(Console.ReadLine());

                if (newNumber < minNumber)
                    minNumber = newNumber;

                if (newNumber > maxNumber)
                    maxNumber = newNumber;

            }


            Console.WriteLine("El numero maximo es " + maxNumber);
            Console.WriteLine("El numero minimo es " + minNumber);
            Console.ReadKey();





















            //List<WorkQueueSchedule> workQueueSchedules = new List<WorkQueueSchedule>()
            //{
            //    new WorkQueueSchedule()
            //    {
            //        Day = 1,
            //        StartHour = TimeSpan.FromHours(8),
            //        EndHour = TimeSpan.FromHours(16)
            //    },
            //    new WorkQueueSchedule()
            //    {
            //        Day = 2,
            //        StartHour = TimeSpan.FromHours(8),
            //        EndHour = TimeSpan.FromHours(16)
            //    },
            //    new WorkQueueSchedule()
            //    {
            //        Day = 3,
            //        StartHour = TimeSpan.FromHours(8),
            //        EndHour = TimeSpan.FromHours(16)
            //    },
            //    new WorkQueueSchedule()
            //    {
            //        Day = 4,
            //        StartHour = TimeSpan.FromHours(8),
            //        EndHour = TimeSpan.FromHours(16)
            //    },
            //    new WorkQueueSchedule()
            //    {
            //        Day = 5,
            //        StartHour = TimeSpan.FromHours(8),
            //        EndHour = TimeSpan.FromHours(16)
            //    },
            //    new WorkQueueSchedule()
            //    {
            //        Day = 6,
            //        StartHour = TimeSpan.FromHours(8),
            //        EndHour = TimeSpan.FromHours(16)
            //    }
            //};


            //var currentDate = DateTime.Now.AddHours(-10);
            //var possibleEndDate = DateTime.Now.AddHours(-10);
            //var totalHours = 16;
            //int totalDays = 0;
            //var hollidays = new List<DateTime>() { };

            //SetPossibleEndDate(hollidays, workQueueSchedules, ref possibleEndDate, totalHours, (int)currentDate.DayOfWeek, currentDate.Hour, ref totalDays);

            //Console.WriteLine($"Fecha de inicio de la tarea: {currentDate.ToLongDateString()} - {currentDate.ToLongTimeString()}.\n\nFecha Final de la tarea: {possibleEndDate.ToLongDateString()} - {possibleEndDate.ToLongTimeString()}. \n con un tiempo de {totalHours}. \nCon una cantidad de dias laborables de {totalDays}.");
            //Console.ReadKey();
        }


        /// <summary>
        /// Permite obtener una fecha final en base a dias y horario laborables definidos y una fecha inicial.
        /// </summary>
        /// <param name="holidays">Son los dias festivos en los cuales si la fecha actual pasada por parametro se encuentra en esa lista entonces no se cuenta como un dia a trabajar.</param>
        /// <param name="schedules">Horario permitido para trabajar.</param>
        /// <param name="possibleEndDates">Fecha inicial y fecha resultante pasada por referencia.</param>
        /// <param name="hourFromSla">Tiempo en horas correspondiente a la cantidad de hora a trabajar.</param>
        /// <param name="dayOfWeek">Dia de la semana en la cual inicia la fecha.</param>
        /// <param name="hour"></param>
        /// <param name="totalDays"></param>
        private static void SetPossibleEndDate(List<DateTime> holidays,
                                               ICollection<WorkQueueSchedule> schedules,
                                               ref DateTime possibleEndDates,
                                               int hourFromSla,
                                               int dayOfWeek,
                                               int hour,
                                               ref int totalDays)
        {

            DateTime currentDate = possibleEndDates.Date;


            if (dayOfWeek > 6)
            {
                SetPossibleEndDate(holidays, schedules, ref possibleEndDates, hourFromSla, 0, hour, ref totalDays);
                return;
            }

            if (hour == 12)
            {
                SetPossibleEndDate(holidays, schedules, ref possibleEndDates, hourFromSla, dayOfWeek, hour + 1, ref totalDays);
                return;
            }

            if (hour > schedules.FirstOrDefault(d => d.Day == dayOfWeek).EndHour.Hours || holidays.Any(d => d.Date == currentDate))
            {
                possibleEndDates = possibleEndDates.AddDays(1);
                var minHour = schedules.Min(d => d.StartHour).Hours;
                totalDays += 1;
                SetPossibleEndDate(holidays, schedules, ref possibleEndDates, hourFromSla, dayOfWeek + 1, minHour, ref totalDays);
                return;
            }

            if (hourFromSla <= 0)
                return;

            if (!schedules.Any(d => d.Day == dayOfWeek))
            {
                possibleEndDates = possibleEndDates.AddDays(1);
                SetPossibleEndDate(holidays, schedules, ref possibleEndDates, hourFromSla, dayOfWeek + 1, hour, ref totalDays);
                return;
            }


            if (hour >= schedules.FirstOrDefault(d => d.Day == dayOfWeek).StartHour.Hours && hour <= schedules.FirstOrDefault(d => d.Day == dayOfWeek).EndHour.Hours)
            {
                hourFromSla -= 1;
                SetPossibleEndDate(holidays, schedules, ref possibleEndDates, hourFromSla, dayOfWeek, hour + 1, ref totalDays);
                return;
            }

        }
    }


}
