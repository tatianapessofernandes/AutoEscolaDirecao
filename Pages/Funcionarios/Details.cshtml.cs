﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscolaDirecao.Data;

namespace AutoEscolaDirecao.Pages.Funcionarios
{
    public class DetailsModel : PageModel
    {
        private readonly AutoEscolaDirecao.Data.AutoEscolaDirecaoContext _context;

        public DetailsModel(AutoEscolaDirecao.Data.AutoEscolaDirecaoContext context)
        {
            _context = context;
        }

        public Funcionarios Funcionarios { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionarios = await _context.Funcionarios.FirstOrDefaultAsync(m => m.ID == id);

            if (Funcionarios == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
