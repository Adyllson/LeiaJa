namespace LeiaJa.Infrastructure.EntityConfiguration;
public class GeneroConfiguration : IEntityTypeConfiguration<GeneroEntity>
{
    public void Configure(EntityTypeBuilder<GeneroEntity> builder)
    {
        builder.ToTable("TBL_GENERO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Genero).
                    IsRequired(true).
                    HasMaxLength(15).
                    HasColumnType("VARCHAR");
            builder.HasData(
                new GeneroEntity(1, "Masculino"),
                new GeneroEntity(2, "Femenino"),
                new GeneroEntity(3, "Outro")
            );
    }
}
