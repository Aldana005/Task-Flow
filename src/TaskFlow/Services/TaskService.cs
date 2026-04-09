using System;
using System.Collections.Generic;
using System.Linq;
using TaskFlow.Models;

namespace TaskFlow.Services 
{
    public class TaskService 
    {
        //lista interna

        private List<TaskItem> _tasks;

        public TaskService() 
        {
            _tasks = new List<TaskItem>();
        }

        //metodo para crear la tarea

        public void CreateTask(string title, string description, string responsible) 
        {
            //generar el id incremental
            int newId;

            if (_tasks.Count > 0)
            {
                newId = _tasks.Max(t => t.Id) + 1;
            }
            else 
            {
                newId = 1;
            }

            //instanciar TaskItem

            var newTask = new TaskItem (title, description, responsible)
            {
                Id = newId,
                Title = title,
                Description = description,
                Responsible = responsible
            };

            _tasks.Add(newTask);
            Console.WriteLine($"Tarea '{title}' creada con éxito con el ID: {newId}");
        } 

    }
}