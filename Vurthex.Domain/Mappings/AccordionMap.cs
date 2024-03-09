using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vurthex.Domain.Models;

namespace Vurthex.Domain.Mappings
{
    public class AccordionMap : IEntityTypeConfiguration<Accordion>
    {
        public void Configure(EntityTypeBuilder<Accordion> builder)
        {
            
        }
    }
}
