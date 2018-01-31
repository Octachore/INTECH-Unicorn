using System;
using System.Collections.Generic;
using System.Linq;

namespace ITI.Unicorn.Core
{
    public class Guard
    {
        public static void NotNull<T>(T argument, string argumentName)
        {
            if (argument == null) throw new ArgumentNullException(argumentName);
        }

        public static void NotNullOrEmpty<T>(IEnumerable<T> argument, string argumentName)
        {
            NotNull(argument, argumentName);
            if (!argument.Any()) throw new ArgumentException($"Enumerable {argumentName} must not be empty.");
        }

        public static void Positive<T>(T argument, string argumentName) where T : IComparable
        {
            if (argument.CompareTo(default(T)) < 0) throw new ArgumentException($"Argument {argumentName} must be positive.");
        }

        public static void StrictlyPositive<T>(T argument, string argumentName) where T : IComparable
        {
            if (argument.CompareTo(default(T)) <= 0) throw new ArgumentException($"Argument {argumentName} must be strictly positive.");
        }

        public static void Negative<T>(T argument, string argumentName) where T : IComparable
        {
            if (argument.CompareTo(default(T)) > 0) throw new ArgumentException($"Argument {argumentName} must be negative.");
        }

        public static void StrictlyNegative<T>(T argument, string argumentName) where T : IComparable
        {
            if (argument.CompareTo(default(T)) >= 0) throw new ArgumentException($"Argument {argumentName} must be strictly negative.");
        }
    }
}
