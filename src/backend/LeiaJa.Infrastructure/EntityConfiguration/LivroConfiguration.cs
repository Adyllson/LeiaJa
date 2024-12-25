namespace LeiaJa.Infrastructure.EntityConfiguration;
public class LivroConfiguration : IEntityTypeConfiguration<LivroEntity>
{
    public void Configure(EntityTypeBuilder<LivroEntity> builder)
    {
        builder.ToTable("TBL_LIVRO");
            builder.HasKey(x => x.Id);
    }
}
