using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace OnlineBooks.Infrastructure
{

    //This is a tool to convert our Cart object to a Json string) file, adn then back (because we can't store Carts in a session) 
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }
        //? for the null

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}

