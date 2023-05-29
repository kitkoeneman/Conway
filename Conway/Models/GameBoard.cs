using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Conway.Models;


public class GameBoard
{
    [BindProperty]
    [Range(10,100)]
    public int Height { get; set; }
    
    [BindProperty]
    [Range(10,100)]
    public int Width { get; set; }

    public int[,]? Board { get; set; }
}
