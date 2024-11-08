﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Wrappers;

namespace ApplicationCore.Interfaces
{
    public interface IEstudiantesService
    {
        Task<Response<object>> GetEstudiantes();
        Task<Response<int>> DeleteEstudiante(int id);

        Task<byte[]> GetPDF();
    }
}
