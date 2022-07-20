using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel  : PageModel

    public List<Pizza> pizzas = new();
    {
        public void OnGet()
        {
             pizzas = PizzaService.GetAll();
    }
}
