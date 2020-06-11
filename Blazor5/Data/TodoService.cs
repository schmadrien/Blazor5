using Blazor5.Pages;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blazor5.Data
{
    public class TodoService
    {

        public async Task<TodoItem[]> GetTodosAsync()
        {
            using (System.IO.FileStream fs = System.IO.File.OpenRead("Data/json/todos.json"))
            {
                var jsonizedData = await JsonSerializer.DeserializeAsync<TodoItem[]>(fs);
                return jsonizedData;
            }
        }

        public async Task UpdateTodosAsync(IList<TodoItem> list)
        {
            Console.WriteLine("Doesn't work rn lol");
            using (System.IO.FileStream fs = System.IO.File.Create("Data/json/todos.json"))
            {
                await Task.FromResult(JsonSerializer.SerializeAsync<IList<TodoItem>>(fs, list));
                //    return jsonizedData;
            }
        }

    }
}
