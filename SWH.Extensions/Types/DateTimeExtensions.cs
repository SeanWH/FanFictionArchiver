// FILE: DateTimeExtensions.cs
// PROJECT: SWH.Extensions
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-17
// DATE MODIFIED: 2021-05-17

namespace SWH.Extensions.Types
{
    using System;

    public static class DateTimeExtensions
    {
        /// <summary>
        /// The date that Unix time begins, Midnight on Jan 01, 1970.
        /// </summary>
        public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Determines how many seconds have elapsed between <see cref="UnixEpoch"/> and dateTime
        /// </summary>
        /// <param name="dateTime">The date to convert</param>
        /// <returns>The number of seconds since 00:00:00 01/01/1970</returns>
        public static long ToUnixTime(this DateTime dateTime) => (long) (dateTime - UnixEpoch).TotalSeconds;

        /// <summary>
        /// Converts a Unix time value to it's equivalent DateTime
        /// </summary>
        /// <param name="unixTime">The value to continue.  This value represents the number of elapsed seconds.</param>
        /// <returns>The date and time of day</returns>
        public static DateTime FromUnixTime(this long unixTime) => UnixEpoch.AddSeconds(unixTime);
    }
}