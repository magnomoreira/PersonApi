﻿using PersonApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonApi.Services.Implementations
{
	interface IPersonService
	{
		Person Create(Person person);
		Person FindById(long id);
		List<Person> FindAll();
		Person Update(Person person);
		void Delete(long id);
	}
}
