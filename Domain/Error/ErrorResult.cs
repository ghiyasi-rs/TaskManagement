﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Error
{
	public class ErrorResult
	{
		public ErrorType Type { get; set; }
		public string Message { get; set; }
	}
}
