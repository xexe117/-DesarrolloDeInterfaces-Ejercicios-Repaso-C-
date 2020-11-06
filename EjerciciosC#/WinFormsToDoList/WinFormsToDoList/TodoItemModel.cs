using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsToDoList
{
    public class TodoItemModel
    {
        public int PositionNumber { get; set; }

        public string Todotxt { get; set; }

        public bool IsComplet { get; set; } = false;

        public string ToDisplay => $"{ PositionNumber }: { Todotxt } (Complete: { IsComplet })";
    }
}
