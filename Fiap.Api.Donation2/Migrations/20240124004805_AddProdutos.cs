using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fiap.Api.Donation2.Migrations
{
    /// <inheritdoc />
    public partial class AddProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ProdutoId", "CategoriaId", "DataCadastro", "DataExpiracao", "Descricao", "Disponivel", "Nome", "SugestaoTroca", "UsuarioId", "Valor" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4770), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4807), "Descrição", true, "Produto 1", "Sugestão de troca", 1, 1.0 },
                    { 2, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4822), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4822), "Descrição", true, "Produto 2", "Sugestão de troca", 1, 1.0 },
                    { 3, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4824), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4824), "Descrição", true, "Produto 3", "Sugestão de troca", 1, 1.0 },
                    { 4, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4826), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4826), "Descrição", true, "Produto 4", "Sugestão de troca", 1, 1.0 },
                    { 5, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4827), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4828), "Descrição", true, "Produto 5", "Sugestão de troca", 1, 1.0 },
                    { 6, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4830), "Descrição", true, "Produto 6", "Sugestão de troca", 1, 1.0 },
                    { 7, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4831), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4832), "Descrição", true, "Produto 7", "Sugestão de troca", 1, 1.0 },
                    { 8, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4833), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4833), "Descrição", true, "Produto 8", "Sugestão de troca", 1, 1.0 },
                    { 9, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4835), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4835), "Descrição", true, "Produto 9", "Sugestão de troca", 1, 1.0 },
                    { 10, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4876), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4876), "Descrição", true, "Produto 10", "Sugestão de troca", 1, 1.0 },
                    { 11, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4878), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4878), "Descrição", true, "Produto 11", "Sugestão de troca", 1, 1.0 },
                    { 12, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4880), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4880), "Descrição", true, "Produto 12", "Sugestão de troca", 1, 1.0 },
                    { 13, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4881), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4882), "Descrição", true, "Produto 13", "Sugestão de troca", 1, 1.0 },
                    { 14, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4883), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4883), "Descrição", true, "Produto 14", "Sugestão de troca", 1, 1.0 },
                    { 15, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4885), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4885), "Descrição", true, "Produto 15", "Sugestão de troca", 1, 1.0 },
                    { 16, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4886), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4887), "Descrição", true, "Produto 16", "Sugestão de troca", 1, 1.0 },
                    { 17, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4888), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4888), "Descrição", true, "Produto 17", "Sugestão de troca", 1, 1.0 },
                    { 18, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4889), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4890), "Descrição", true, "Produto 18", "Sugestão de troca", 1, 1.0 },
                    { 19, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4891), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4891), "Descrição", true, "Produto 19", "Sugestão de troca", 1, 1.0 },
                    { 20, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4893), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4893), "Descrição", true, "Produto 20", "Sugestão de troca", 1, 1.0 },
                    { 21, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4894), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4894), "Descrição", true, "Produto 21", "Sugestão de troca", 1, 1.0 },
                    { 22, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4896), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4896), "Descrição", true, "Produto 22", "Sugestão de troca", 1, 1.0 },
                    { 23, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4897), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4898), "Descrição", true, "Produto 23", "Sugestão de troca", 1, 1.0 },
                    { 24, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4899), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4899), "Descrição", true, "Produto 24", "Sugestão de troca", 1, 1.0 },
                    { 25, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4900), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4901), "Descrição", true, "Produto 25", "Sugestão de troca", 1, 1.0 },
                    { 26, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4902), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4902), "Descrição", true, "Produto 26", "Sugestão de troca", 1, 1.0 },
                    { 27, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4904), "Descrição", true, "Produto 27", "Sugestão de troca", 1, 1.0 },
                    { 28, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4905), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4905), "Descrição", true, "Produto 28", "Sugestão de troca", 1, 1.0 },
                    { 29, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4906), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4907), "Descrição", true, "Produto 29", "Sugestão de troca", 1, 1.0 },
                    { 30, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4908), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4908), "Descrição", true, "Produto 30", "Sugestão de troca", 1, 1.0 },
                    { 31, 1, new DateTime(2024, 1, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4909), new DateTime(2025, 9, 23, 21, 48, 5, 576, DateTimeKind.Local).AddTicks(4910), "Descrição", true, "Produto 31", "Sugestão de troca", 1, 1.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31);
        }
    }
}
