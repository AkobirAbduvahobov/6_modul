﻿namespace ToDoList.Bll.DTOs;

public class ToDoItemCreateDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
}
