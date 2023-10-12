﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_10_Garbarino_Aboudara_Kalinscky.Models;

namespace TP_10_Garbarino_Aboudara_Kalinscky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.listarSeries();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public Series VerDetalleActoresAjax(int IdSerie){
        Serie = BD.listarActores(IdSerie);
        return Serie;
    }
    public Temporadas VerDetalleTemporadaAjax(int IdSerie){
        Temporadas = BD.listarTemporadas(IdSerie);
        return Temporadas;
    }
}
