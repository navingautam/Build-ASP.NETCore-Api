﻿using LandonApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandonApi.Models
{
    public class SearchOptions<T, TEntity> : IValidatableObject
    {
        public string[] Search { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var processor = new SearchOptionsProcessor<T, TEntity>(Search);

            var validTerms = processor.GetValidTerms().Select(x => x.Name);
            var invalidTerms = processor.GetAllTerms().Select(x => x.Name)
                .Except(validTerms, StringComparer.OrdinalIgnoreCase);

            foreach (var term in invalidTerms)
            {
                yield return new ValidationResult(
                    $"Invalid search term '{term}'.",
                    new[] { nameof(Search) });
            }
        }

        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
        {
            throw new NotImplementedException();
        }
    }
}
