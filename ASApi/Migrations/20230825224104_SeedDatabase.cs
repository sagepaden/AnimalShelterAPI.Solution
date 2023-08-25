using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASApi.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, "Golden Retriever", "Buddy", "Dog" },
                    { 2, 3, "Labrador Retriever", "Molly", "Dog" },
                    { 3, 2, "Poodle", "Coco", "Dog" },
                    { 4, 1, "Labrador Retriever", "Charlie", "Dog" },
                    { 5, 4, "Labrador Retriever", "Lucy", "Dog" },
                    { 6, 6, "Golden Retriever", "Bailey", "Dog" },
                    { 7, 7, "Golden Retriever", "Daisy", "Dog" },
                    { 8, 8, "Pug", "Maggie", "Dog" },
                    { 9, 9, "Pug", "Sophie", "Dog" },
                    { 10, 10, "Ocicat", "Chloe", "Cat" },
                    { 11, 11, "Ocicat", "Sadie", "Cat" },
                    { 12, 12, "Persian", "Lola", "Cat" },
                    { 13, 13, "Persian", "Zoe", "Cat" },
                    { 14, 14, "Ragdoll", "Duke", "Cat" },
                    { 15, 15, "Ragdoll", "Lily", "Cat" },
                    { 16, 16, "Siamese", "Rocky", "Cat" },
                    { 17, 17, "Siamese", "Luna", "Cat" },
                    { 18, 18, "Sphynx", "Harley", "Cat" },
                    { 19, 19, "Sphynx", "Mia", "Cat" },
                    { 20, 20, "Sphynx", "Max", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);
        }
    }
}
