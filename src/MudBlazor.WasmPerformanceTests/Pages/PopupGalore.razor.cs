// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MudBlazor.WasmPerformanceTests.Pages
{
    public partial class PopupGalore
    {
        private Elem[] Items = Array.Empty<Elem>();

        private async Task Switcharoo()
        {
            await Task.Delay(10);
            Items = Enumerable.Range(0, 1).Select(r => new Elem()).ToArray();
        }

        private void Clear()
        {
            Items = Array.Empty<Elem>();
        }
    }

    public class Elem
    {
        private static int _theId = 1;

        public Elem()
        {
            var myId = _theId++;
            Title = $"I'm element {myId}";
            Body = $"And i'm very {(myId % 2 == 0 ? "even" : "odd")}";

            SubElems = Enumerable.Range(0, myId % 3 + 1).Select(r => new SubElem(myId)).ToArray();
        }

        public readonly string Title;
        public readonly string Body;
        public readonly SubElem[] SubElems;
    }

    public class SubElem
    {
        private static int _subId = 1;

        public SubElem(long elemId)
        {
            _myId = _subId++;

            SomeData1 = $"{elemId}.{_myId}";
            SomeData2 = $"Hi! I'm {SomeData1}";
        }

        public bool IsEven => (_myId & 1) == 0;

        public readonly int _myId;

        public readonly string SomeData1;
        public readonly string SomeData2;
    }
}
