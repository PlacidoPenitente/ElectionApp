﻿namespace ElectionApp.Model
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinimumWinners { get; set; }
        public int MaximumWinners { get; set; }
    }
}
