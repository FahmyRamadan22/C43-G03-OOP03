using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment03
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override int GetHashCode()
            => HashCode.Combine(Hours, Minutes, Seconds);

        public override bool Equals(object? obj)
        {
            Duration? right = obj as Duration;
            if (right == null) return false;

            return (Hours == right.Hours && Minutes == right.Minutes && Seconds == right.Seconds);
        }

        public override string ToString()
            => $"{(Hours == 0 ? "" : $"Hours: {Hours} ")}" +
               $"{(Minutes == 0 ? "" : $"Minutes: {Minutes} ")} {(Seconds == 0 ? "" : $"Seconds: {Seconds}")}";

        public Duration(int seconds)
        {
            Hours = seconds / 3600;  
            Minutes = (seconds % 3600)   / 60; 
            Seconds = (seconds % 3600)  % 60; 

        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public static Duration operator +(Duration Left, Duration Right)
        {
            if (Right is null)
                return Left;

            return new Duration(Left.Hours + Right.Hours, Left.Minutes + Right.Minutes, Left.Seconds + Right.Seconds);
        }

        public static Duration operator +(Duration Left, int Right)
        {
            Duration Result = new(Right);
            return Left + Result;
        }

        public static Duration operator +(int Left, Duration Right)
        {
            Duration Result = new(Left);
            return Result + Right;
        }

        public static Duration operator ++(Duration duration)
        {
            if (duration.Minutes == 59)
                return new Duration(duration.Hours + 1, 0, duration.Seconds);

            return new Duration(duration.Hours, duration.Minutes + 1, duration.Seconds);
        }

        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration(Left.Hours - Right.Hours, Left.Minutes - Right.Minutes, Left.Seconds - Right.Seconds);
        }

        public static Duration operator --(Duration duration)
        {
            if (duration.Minutes == 0)
                if (duration.Hours > 0)
                    return new Duration(duration.Hours - 1, 59, duration.Seconds);
                else
                    return new Duration(0, 0, duration.Seconds);


            return new Duration(duration.Hours, duration.Minutes - 1, duration.Seconds);
        }

        public static bool operator >(Duration Left, Duration Right)
        {
            if (Left.Hours != Right.Hours)
                return Left.Hours > Right.Hours;
            else if (Left.Minutes != Right.Minutes)
                return Left.Minutes > Right.Minutes;
            else
                return Left.Seconds > Right.Seconds;
        }

        public static bool operator <(Duration Left, Duration Right)
        {
            if (Left.Hours != Right.Hours)
                return Left.Hours < Right.Hours;
            else if (Left.Minutes != Right.Minutes)
                return Left.Minutes < Right.Minutes;
            else
                return Left.Seconds < Right.Seconds;

        }

        public static bool operator <=(Duration Left, Duration Right)
        {
            return Left < Right || Left.Equals(Right);
        }

        public static bool operator >=(Duration Left, Duration Right)
        {
            return Left > Right || Left.Equals(Right);
        }


        public static implicit operator bool(Duration duration)
        {
            return duration != null && duration.Hours > 0;
        }

        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(2003, 12, 25, (duration?.Hours) ?? 0, (duration?.Minutes) ?? 0, (duration?.Seconds) ?? 0);
        }



    }
}
