﻿/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2013-2021  Denis Kuzmin <x-3F@outlook.com> github/3F
 * Copyright (c) MvsSln contributors https://github.com/3F/MvsSln/graphs/contributors
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/
/*
 * origin: net.r_eg.Conari.Log :: Copyright (c) 2016-2020  Denis Kuzmin < x-3F@outlook.com > GitHub/3F
*/

using System;

namespace net.r_eg.MvsSln.Log
{
    public interface ISender
    {
        /// <summary>
        /// When message has been received.
        /// </summary>
        event EventHandler<Message> Received;

        /// <summary>
        /// To send new message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        void send(object sender, Message msg);

        /// <summary>
        /// To send new message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        void send(object sender, string msg);

        /// <summary>
        /// To send new message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        void send(object sender, string msg, Message.Level type);

        /// <summary>
        /// To send new message with default sender as typeof(T).
        /// It useful for static methods etc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="msg"></param>
        void send<T>(Message msg) where T: class;

        /// <summary>
        /// To send new message with default sender as typeof(T).
        /// It useful for static methods etc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="msg"></param>
        void send<T>(string msg) where T : class;

        /// <summary>
        /// To send new message with default sender as typeof(T).
        /// It useful for static methods etc.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        void send<T>(string msg, Message.Level type) where T : class;
    }
}
