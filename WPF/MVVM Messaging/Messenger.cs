using MVVM_Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Messaging
{
    //class Messenger
    //{
    //    private readonly Dictionary<Type, List<Action<object>>> subscriptions = new Dictionary<Type, List<Action<object>>>();

    //    public void Subscribe<T>(Action<object> action) where T : IMessage
    //    {
    //        var type = typeof(T);
    //        if (!subscriptions.ContainsKey(type))
    //        {
    //            subscriptions[type] = new List<Action<object>>();
    //        }
    //        subscriptions[type].Add(action);
    //    }

    //    public void Send<T>(T message) where T : IMessage 
    //    {
    //        var type = typeof(T);
    //        if (subscriptions.ContainsKey(type))
    //        {
    //            foreach (var action in subscriptions[type])
    //            {
    //                action.Invoke(message);
    //            }
    //        }
    //    }

    //}
}
