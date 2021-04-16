﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string LastName { get; set; }
		public string FirstMidName { get; set; }
		[BindProperty, DataType(DataType.Date)]
		public DateTime EnrollmentDate { get; set; }

		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
