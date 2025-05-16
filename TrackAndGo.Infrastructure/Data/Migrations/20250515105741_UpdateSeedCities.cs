using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackAndGo.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 135,
                column: "Name",
                value: "Alexanderfeld");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 136,
                column: "Name",
                value: "Alexandru Ioan Cuza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 137,
                column: "Name",
                value: "Andrușul de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 138,
                column: "Name",
                value: "Andrușul de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 139,
                column: "Name",
                value: "Badicul Moldovenesc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 140,
                column: "Name",
                value: "Baurci-Moldoveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 141,
                column: "Name",
                value: "Borceag");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 142,
                column: "Name",
                value: "Bucuria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 143,
                column: "Name",
                value: "Burlacu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 144,
                column: "Name",
                value: "Burlăceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 145,
                column: "Name",
                value: "Brînza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 146,
                column: "Name",
                value: "Cahul");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 147,
                column: "Name",
                value: "Chioselia Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 148,
                column: "Name",
                value: "Chircani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 149,
                column: "Name",
                value: "Cîșlița-Prut");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 150,
                column: "Name",
                value: "Colibași");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 151,
                column: "Name",
                value: "Cotihana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 152,
                column: "Name",
                value: "Crihana Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 153,
                column: "Name",
                value: "Cucoara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 154,
                column: "Name",
                value: "Doina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 155,
                column: "Name",
                value: "Frumușica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 156,
                column: "Name",
                value: "Găvănoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 157,
                column: "Name",
                value: "Giurgiulești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 158,
                column: "Name",
                value: "Greceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 159,
                column: "Name",
                value: "Huluboaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 160,
                column: "Name",
                value: "Hutulu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 161,
                column: "Name",
                value: "Iasnaia Poleana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 162,
                column: "Name",
                value: "Iujnoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 163,
                column: "Name",
                value: "Larga Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 164,
                column: "Name",
                value: "Larga Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 165,
                column: "Name",
                value: "Lebedenco");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 166,
                column: "Name",
                value: "Lopățica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 167,
                column: "Name",
                value: "Lucești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 168,
                column: "Name",
                value: "Manta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 169,
                column: "Name",
                value: "Moscovei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 170,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 171,
                column: "Name",
                value: "Paicu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 172,
                column: "Name",
                value: "Pașcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 173,
                column: "Name",
                value: "Pelinei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Roșu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Rumeanțev" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Sătuc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Slobozia Mare" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Spicoasa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Taraclia de Salcie" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Tartaul de Salcie" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Tătărești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Tretești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Trifeștii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Tudorești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Ursoaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Vadul lui Isac" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Văleni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Vladimirovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 7, "Zîrnești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 190,
                column: "Name",
                value: "Camenca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 191,
                column: "Name",
                value: "Caterinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "Crasnîi Octeabri");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 193,
                column: "Name",
                value: "Cuzmin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 194,
                column: "Name",
                value: "Hristovaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 195,
                column: "Name",
                value: "Hrușca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 196,
                column: "Name",
                value: "Ocnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 197,
                column: "Name",
                value: "Podoima");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 198,
                column: "Name",
                value: "Rașcov");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 199,
                column: "Name",
                value: "Rotari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 200,
                column: "Name",
                value: "Severinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 201,
                column: "Name",
                value: "Slobozia-Rașcov");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 202,
                column: "Name",
                value: "Valea Adîncă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Bahmut" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Bahmut (stație c.f.)" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Bahu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Bravicea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Buda" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Bularda" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Căbăiești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Călărași" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Dereneu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Duma" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Frumoasa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Hirova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Hîrbovăț" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Hîrjauca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Hoginești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Horodiște" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Leordoaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Meleșeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Mîndra" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Nișcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Novaci" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Onișcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Oricova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Palanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Parcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Păulești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 229,
                column: "Name",
                value: "Peticeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 230,
                column: "Name",
                value: "Pitușca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 231,
                column: "Name",
                value: "Pîrjolteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 232,
                column: "Name",
                value: "Podul Lung");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 233,
                column: "Name",
                value: "Răciula");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 234,
                column: "Name",
                value: "Rădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 235,
                column: "Name",
                value: "Sadova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 236,
                column: "Name",
                value: "Săseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 237,
                column: "Name",
                value: "Schinoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 238,
                column: "Name",
                value: "Seliștea Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 239,
                column: "Name",
                value: "Sipoteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 240,
                column: "Name",
                value: "Sverida");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 241,
                column: "Name",
                value: "Temeleuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Tuzara" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Țibirica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Ursari" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Vălcineț" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 9, "Vărzăreștii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 247,
                column: "Name",
                value: "Acui");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 248,
                column: "Name",
                value: "Alexandrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 249,
                column: "Name",
                value: "Antonești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 250,
                column: "Name",
                value: "Baimaclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 251,
                column: "Name",
                value: "Bobocica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 252,
                column: "Name",
                value: "Cania");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 253,
                column: "Name",
                value: "Cantemir");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 254,
                column: "Name",
                value: "Capaclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 255,
                column: "Name",
                value: "Chioselia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "Ciobalaccia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 257,
                column: "Name",
                value: "Cîietu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 258,
                column: "Name",
                value: "Cîrpești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 259,
                column: "Name",
                value: "Cîșla");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 260,
                column: "Name",
                value: "Crăciun");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 261,
                column: "Name",
                value: "Cociulia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 262,
                column: "Name",
                value: "Constantinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 263,
                column: "Name",
                value: "Coștangalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 264,
                column: "Name",
                value: "Dimitrova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 265,
                column: "Name",
                value: "Enichioi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 266,
                column: "Name",
                value: "Flocoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 267,
                column: "Name",
                value: "Floricica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 268,
                column: "Name",
                value: "Ghioltosu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 269,
                column: "Name",
                value: "Gotești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 270,
                column: "Name",
                value: "Haragîș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 271,
                column: "Name",
                value: "Hănăseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 272,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 273,
                column: "Name",
                value: "Iepureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 274,
                column: "Name",
                value: "Lărguța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 275,
                column: "Name",
                value: "Leca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 276,
                column: "Name",
                value: "Lingura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 277,
                column: "Name",
                value: "Pleșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 278,
                column: "Name",
                value: "Plopi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 279,
                column: "Name",
                value: "Popovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 280,
                column: "Name",
                value: "Porumbești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 281,
                column: "Name",
                value: "Sadîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 282,
                column: "Name",
                value: "Stoianovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 283,
                column: "Name",
                value: "Suhat");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 284,
                column: "Name",
                value: "Șamalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Șofranovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Taraclia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Tartaul" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Tătărășeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Toceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Țărăncuța" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Țiganca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Țiganca Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Țolica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Victorovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Vișniovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Vîlcele" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 297,
                column: "Name",
                value: "Baccealia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 298,
                column: "Name",
                value: "Baimaclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 299,
                column: "Name",
                value: "Baurci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 300,
                column: "Name",
                value: "Căinari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 301,
                column: "Name",
                value: "Căinari (stație c.f.)");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 302,
                column: "Name",
                value: "Căușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 303,
                column: "Name",
                value: "Chircăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 304,
                column: "Name",
                value: "Chircăieștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 305,
                column: "Name",
                value: "Chițcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 306,
                column: "Name",
                value: "Ciuflești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 307,
                column: "Name",
                value: "Cîrnățeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 308,
                column: "Name",
                value: "Cîrnățenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 309,
                column: "Name",
                value: "Constantinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 310,
                column: "Name",
                value: "Copanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 311,
                column: "Name",
                value: "Coșcalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 312,
                column: "Name",
                value: "Cremenciug");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 313,
                column: "Name",
                value: "Fîrlădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 314,
                column: "Name",
                value: "Fîrlădenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 315,
                column: "Name",
                value: "Florica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 316,
                column: "Name",
                value: "Gîsca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 317,
                column: "Name",
                value: "Grădinița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 318,
                column: "Name",
                value: "Grigorievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 319,
                column: "Name",
                value: "Hagimus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 320,
                column: "Name",
                value: "Leuntea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 321,
                column: "Name",
                value: "Marianca de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 322,
                column: "Name",
                value: "Merenești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 323,
                column: "Name",
                value: "Opaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 324,
                column: "Name",
                value: "Pervomaisc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 325,
                column: "Name",
                value: "Plop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 326,
                column: "Name",
                value: "Plop-Știubei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 327,
                column: "Name",
                value: "Săiți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 328,
                column: "Name",
                value: "Sălcuța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 329,
                column: "Name",
                value: "Sălcuța Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 330,
                column: "Name",
                value: "Surchiceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 331,
                column: "Name",
                value: "Ștefănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 332,
                column: "Name",
                value: "Taraclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 333,
                column: "Name",
                value: "Tănătari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 334,
                column: "Name",
                value: "Tănătarii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 335,
                column: "Name",
                value: "Tocuz");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Tricolici" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Ucrainca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Ursoaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Ursoaia Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Valea Verde" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Zahorna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Zaim" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Zaim (stație c.f.)" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Zviozdocica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 345,
                column: "Name",
                value: "Albina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 346,
                column: "Name",
                value: "Artimonovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 347,
                column: "Name",
                value: "Batîr");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 348,
                column: "Name",
                value: "Bogdanovca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 349,
                column: "Name",
                value: "Bogdanovca Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 350,
                column: "Name",
                value: "Cenac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 351,
                column: "Name",
                value: "Cimișlia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 352,
                column: "Name",
                value: "Ciucur-Mingir");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 353,
                column: "Name",
                value: "Codreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 354,
                column: "Name",
                value: "Coștangalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 355,
                column: "Name",
                value: "Dimitrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 356,
                column: "Name",
                value: "Ecaterinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 357,
                column: "Name",
                value: "Fetița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 358,
                column: "Name",
                value: "Gradiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 359,
                column: "Name",
                value: "Gura Galbenei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 360,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 361,
                column: "Name",
                value: "Ialpug");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 362,
                column: "Name",
                value: "Ialpujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 363,
                column: "Name",
                value: "Iurievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 364,
                column: "Name",
                value: "Ivanovca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 365,
                column: "Name",
                value: "Javgur");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 366,
                column: "Name",
                value: "Lipoveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 367,
                column: "Name",
                value: "Marienfeld");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 368,
                column: "Name",
                value: "Maximeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 369,
                column: "Name",
                value: "Mereni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 370,
                column: "Name",
                value: "Mihailovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 371,
                column: "Name",
                value: "Munteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 372,
                column: "Name",
                value: "Porumbrei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 373,
                column: "Name",
                value: "Prisaca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 374,
                column: "Name",
                value: "Sagaidac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 375,
                column: "Name",
                value: "Sagaidacul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 376,
                column: "Name",
                value: "Satul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 377,
                column: "Name",
                value: "Schinoșica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 378,
                column: "Name",
                value: "Selemet");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 379,
                column: "Name",
                value: "Suric");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 380,
                column: "Name",
                value: "Topala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 381,
                column: "Name",
                value: "Troițcoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Valea Perjei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Zloți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 384,
                column: "Name",
                value: "Bălăbănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 385,
                column: "Name",
                value: "Bălășești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 386,
                column: "Name",
                value: "Bălțata");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 387,
                column: "Name",
                value: "Bălțata de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 388,
                column: "Name",
                value: "Boșcana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 389,
                column: "Name",
                value: "Chetroasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 390,
                column: "Name",
                value: "Cimișeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 391,
                column: "Name",
                value: "Ciopleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 392,
                column: "Name",
                value: "Corjova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 393,
                column: "Name",
                value: "Coșernița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 394,
                column: "Name",
                value: "Criuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 395,
                column: "Name",
                value: "Cruglic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 396,
                column: "Name",
                value: "Dolinnoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 397,
                column: "Name",
                value: "Drăsliceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 398,
                column: "Name",
                value: "Dubăsarii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 399,
                column: "Name",
                value: "Hîrtopul Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 400,
                column: "Name",
                value: "Hîrtopul Mic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 401,
                column: "Name",
                value: "Hrușova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 402,
                column: "Name",
                value: "Ișnovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 403,
                column: "Name",
                value: "Izbiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 404,
                column: "Name",
                value: "Jevreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 405,
                column: "Name",
                value: "Logănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 406,
                column: "Name",
                value: "Mașcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 407,
                column: "Name",
                value: "Mărdăreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 408,
                column: "Name",
                value: "Măgdăcești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 409,
                column: "Name",
                value: "Mălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 410,
                column: "Name",
                value: "Mălăieștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 411,
                column: "Name",
                value: "Miclești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 412,
                column: "Name",
                value: "Ohrincea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 413,
                column: "Name",
                value: "Onițcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 414,
                column: "Name",
                value: "Pașcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 415,
                column: "Name",
                value: "Porumbeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 416,
                column: "Name",
                value: "Ratuș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 417,
                column: "Name",
                value: "Răculești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 418,
                column: "Name",
                value: "Rîșcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 419,
                column: "Name",
                value: "Sagaidac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Sagaidacul de Sus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Slobozia-Dușca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Stețcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Valea Coloniței" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Valea Satului" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Zăicana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Zolonceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 427,
                column: "Name",
                value: "Arionești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 428,
                column: "Name",
                value: "Baraboi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 429,
                column: "Name",
                value: "Boroseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 430,
                column: "Name",
                value: "Braicău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 431,
                column: "Name",
                value: "Briceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 432,
                column: "Name",
                value: "Briceva");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 433,
                column: "Name",
                value: "Caraiman");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 434,
                column: "Name",
                value: "Cernoleuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 435,
                column: "Name",
                value: "Climăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 436,
                column: "Name",
                value: "Codrenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 437,
                column: "Name",
                value: "Corbu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 438,
                column: "Name",
                value: "Crișcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 439,
                column: "Name",
                value: "Dondușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 440,
                column: "Name",
                value: "Dondușeni (sat)");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 441,
                column: "Name",
                value: "Elenovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 442,
                column: "Name",
                value: "Elizavetovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 443,
                column: "Name",
                value: "Frasin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 444,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 445,
                column: "Name",
                value: "Moșana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 446,
                column: "Name",
                value: "Octeabriscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 447,
                column: "Name",
                value: "Pivniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 448,
                column: "Name",
                value: "Plop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 449,
                column: "Name",
                value: "Pocrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 450,
                column: "Name",
                value: "Rediul Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 451,
                column: "Name",
                value: "Scăieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 452,
                column: "Name",
                value: "Sudarca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 453,
                column: "Name",
                value: "Teleșeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 454,
                column: "Name",
                value: "Teleșeuca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 455,
                column: "Name",
                value: "Tîrnova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 456,
                column: "Name",
                value: "Țaul");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Antoneuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Baroncea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Baroncea Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Ceapaevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Chetrosu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Cotova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 463,
                column: "Name",
                value: "Dominteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 464,
                column: "Name",
                value: "Drochia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 465,
                column: "Name",
                value: "Drochia (sat)");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 466,
                column: "Name",
                value: "Fîntînița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 467,
                column: "Name",
                value: "Ghizdita (stație c.f.)");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 468,
                column: "Name",
                value: "Gribova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 469,
                column: "Name",
                value: "Hăsnășenii Mari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 470,
                column: "Name",
                value: "Hăsnășenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 471,
                column: "Name",
                value: "Holoșnița Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 472,
                column: "Name",
                value: "Iliciovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 473,
                column: "Name",
                value: "Lazo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 474,
                column: "Name",
                value: "Maramonovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 475,
                column: "Name",
                value: "Măcăreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 476,
                column: "Name",
                value: "Miciurin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 477,
                column: "Name",
                value: "Mîndîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 478,
                column: "Name",
                value: "Moara de Piatră");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 479,
                column: "Name",
                value: "Nicoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 480,
                column: "Name",
                value: "Ochiul Alb");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 481,
                column: "Name",
                value: "Palanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 482,
                column: "Name",
                value: "Pelinia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 483,
                column: "Name",
                value: "Pelinia (stație c.f.)");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 484,
                column: "Name",
                value: "Pervomaiscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 485,
                column: "Name",
                value: "Petreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 486,
                column: "Name",
                value: "Popeștii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 487,
                column: "Name",
                value: "Popeștii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 488,
                column: "Name",
                value: "Popeștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 489,
                column: "Name",
                value: "Sergheuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 490,
                column: "Name",
                value: "Sofia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 491,
                column: "Name",
                value: "Șalvirii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 492,
                column: "Name",
                value: "Șalvirii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Șuri" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Șurii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Țarigrad" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 15, "Zgurița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 497,
                column: "Name",
                value: "Cocieri");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 498,
                column: "Name",
                value: "Corjova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 499,
                column: "Name",
                value: "Coșnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 500,
                column: "Name",
                value: "Doroțcaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 501,
                column: "Name",
                value: "Holercani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 502,
                column: "Name",
                value: "Mahala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 503,
                column: "Name",
                value: "Mărcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 504,
                column: "Name",
                value: "Molovata");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 505,
                column: "Name",
                value: "Molovata Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 506,
                column: "Name",
                value: "Oxentea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 507,
                column: "Name",
                value: "Pîrîta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 508,
                column: "Name",
                value: "Pohrebea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 509,
                column: "Name",
                value: "Roghi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 510,
                column: "Name",
                value: "Ustia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 511,
                column: "Name",
                value: "Vasilievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 512,
                column: "Name",
                value: "Comisarovca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 513,
                column: "Name",
                value: "Crasnîi Vinogradari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 514,
                column: "Name",
                value: "Doibani I");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 515,
                column: "Name",
                value: "Dubăsari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 516,
                column: "Name",
                value: "Dubău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 517,
                column: "Name",
                value: "Dzerjinscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 518,
                column: "Name",
                value: "Goian");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 519,
                column: "Name",
                value: "Harmațca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 520,
                column: "Name",
                value: "Lunga");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 521,
                column: "Name",
                value: "Țîbuleuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Alexăndreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Alexeevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Bădragii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Bădragii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Bleșteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Brătușeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Brătușenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Brînzeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Burlănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 531,
                column: "Name",
                value: "Buzdugeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 532,
                column: "Name",
                value: "Cepeleuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 533,
                column: "Name",
                value: "Chetroșica Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 534,
                column: "Name",
                value: "Chetroșica Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 535,
                column: "Name",
                value: "Chiurt");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 536,
                column: "Name",
                value: "Clișcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 537,
                column: "Name",
                value: "Constantinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 538,
                column: "Name",
                value: "Corpaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 539,
                column: "Name",
                value: "Cuconeștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 540,
                column: "Name",
                value: "Cuconeștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 541,
                column: "Name",
                value: "Cupcini");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 542,
                column: "Name",
                value: "Edineț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 543,
                column: "Name",
                value: "Fetești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 544,
                column: "Name",
                value: "Fîntîna Albă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 545,
                column: "Name",
                value: "Gașpar");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 546,
                column: "Name",
                value: "Goleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 547,
                column: "Name",
                value: "Gordinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 548,
                column: "Name",
                value: "Gordineștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 549,
                column: "Name",
                value: "Hancăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 550,
                column: "Name",
                value: "Hincăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 551,
                column: "Name",
                value: "Hlinaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 552,
                column: "Name",
                value: "Hlinaia Mică");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 553,
                column: "Name",
                value: "Iachimeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 554,
                column: "Name",
                value: "Lopatnic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 555,
                column: "Name",
                value: "Onești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Parcova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Poiana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Rîngaci" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Rotunda" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Ruseni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Slobodca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Stolniceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Șofrîncani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Terebna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Tîrnova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Trinca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Vancicăuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Viișoara" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Volodeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 17, "Zăbriceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 571,
                column: "Name",
                value: "Albinețul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 572,
                column: "Name",
                value: "Albinețul Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 573,
                column: "Name",
                value: "Beleuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 574,
                column: "Name",
                value: "Bocani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 575,
                column: "Name",
                value: "Bocșa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 576,
                column: "Name",
                value: "Burghelea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 577,
                column: "Name",
                value: "Catranîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 578,
                column: "Name",
                value: "Călinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 579,
                column: "Name",
                value: "Călugăr");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 580,
                column: "Name",
                value: "Chetriș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 581,
                column: "Name",
                value: "Chetrișul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 582,
                column: "Name",
                value: "Ciolacu Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 583,
                column: "Name",
                value: "Ciolacu Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 584,
                column: "Name",
                value: "Ciuluc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 585,
                column: "Name",
                value: "Comarovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 586,
                column: "Name",
                value: "Cuzmenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 587,
                column: "Name",
                value: "Doltu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 588,
                column: "Name",
                value: "Drujineni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 589,
                column: "Name",
                value: "Egorovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 590,
                column: "Name",
                value: "Fălești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 591,
                column: "Name",
                value: "Făgădău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 592,
                column: "Name",
                value: "Făleștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 593,
                column: "Name",
                value: "Frumușica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 594,
                column: "Name",
                value: "Glinjeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 595,
                column: "Name",
                value: "Hiliuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 596,
                column: "Name",
                value: "Hitrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 597,
                column: "Name",
                value: "Hîncești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 598,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 599,
                column: "Name",
                value: "Horești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 600,
                column: "Name",
                value: "Hrubna Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 601,
                column: "Name",
                value: "Ilenuța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 602,
                column: "Name",
                value: "Ișcălău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 603,
                column: "Name",
                value: "Ivanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 604,
                column: "Name",
                value: "Izvoare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Logofteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Lucăceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Măgura" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Măgura Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Măgureanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Mărăndeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Moldoveanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Musteața" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Natalievca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Năvîrneț" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Nicolaevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Obreja Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Obreja Veche" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pervomaisc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pietrosu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pietrosul Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pînzăreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pînzărenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pîrlița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pocrovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pompa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Popovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Pruteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Răuțel" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Răuțelul Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Rediul de Jos" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Rediul de Sus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Risipeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Sărata Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Sărata Veche" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Scumpia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Socii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Socii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Suvorovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Șoltoaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Taxobeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Țapoc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Unteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Valea Rusului" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Vrănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 645,
                column: "Name",
                value: "Alexandrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 646,
                column: "Name",
                value: "Alexeevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 647,
                column: "Name",
                value: "Antonovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 648,
                column: "Name",
                value: "Băhrinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 649,
                column: "Name",
                value: "Bezeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 650,
                column: "Name",
                value: "Bobulești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 651,
                column: "Name",
                value: "Bursuc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 652,
                column: "Name",
                value: "Cașunca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 653,
                column: "Name",
                value: "Căprești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 654,
                column: "Name",
                value: "Cenușa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 655,
                column: "Name",
                value: "Cernița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 656,
                column: "Name",
                value: "Chirilovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 657,
                column: "Name",
                value: "Ciripcău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 658,
                column: "Name",
                value: "Ciutulești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 659,
                column: "Name",
                value: "Coșernița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 660,
                column: "Name",
                value: "Cuhureștii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 661,
                column: "Name",
                value: "Cuhureștii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 662,
                column: "Name",
                value: "Cunicea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 663,
                column: "Name",
                value: "Domulgeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 664,
                column: "Name",
                value: "Dumitreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 665,
                column: "Name",
                value: "Făgădău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 666,
                column: "Name",
                value: "Florești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 667,
                column: "Name",
                value: "Frumușica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 668,
                column: "Name",
                value: "Frumușica Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 669,
                column: "Name",
                value: "Frunzești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 670,
                column: "Name",
                value: "Ghindești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 671,
                column: "Name",
                value: "Gura Camencii");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 672,
                column: "Name",
                value: "Gura Căinarului");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 673,
                column: "Name",
                value: "Gvozdova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 674,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 675,
                column: "Name",
                value: "Ion Vodă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 676,
                column: "Name",
                value: "Iliciovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 677,
                column: "Name",
                value: "Ivanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 678,
                column: "Name",
                value: "Izvoare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Japca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Lunga" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Maiscoe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Mărinești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Mărculești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Mihailovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Năpadova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Nicolaevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Nicolaevca (sat)" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Octeabriscoe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Prajila" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Prodănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Prodăneștii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Putinești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Rădulenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Rădulenii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Roșietici" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Roșieticii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Sănătăuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Scăieni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Sevirova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Sîrbești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Stîrceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ștefănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Temeleuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Tîrgul Vertiujeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Trifănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Țipordei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Țîra" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Țîra (stație c.f.)" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Unchitești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Unchitești (stație c.f.)" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Valea Rădoaiei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Vărvăreuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Văscăuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Vertiujeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Zarojeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Zăluceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 717,
                column: "Name",
                value: "Balatina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 718,
                column: "Name",
                value: "Bisericani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 719,
                column: "Name",
                value: "Brînzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 720,
                column: "Name",
                value: "Butești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 721,
                column: "Name",
                value: "Cajba");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 722,
                column: "Name",
                value: "Camenca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 723,
                column: "Name",
                value: "Camencuța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 724,
                column: "Name",
                value: "Ciuciulea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 725,
                column: "Name",
                value: "Clococenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 726,
                column: "Name",
                value: "Cobani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 727,
                column: "Name",
                value: "Cot");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 728,
                column: "Name",
                value: "Cuhnești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 729,
                column: "Name",
                value: "Danu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 730,
                column: "Name",
                value: "Dușmani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 731,
                column: "Name",
                value: "Fundurii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 732,
                column: "Name",
                value: "Fundurii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 733,
                column: "Name",
                value: "Glodeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 734,
                column: "Name",
                value: "Hîjdieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 735,
                column: "Name",
                value: "Iabloana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 736,
                column: "Name",
                value: "Limbenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 737,
                column: "Name",
                value: "Limbenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 738,
                column: "Name",
                value: "Lipovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 739,
                column: "Name",
                value: "Moara Domnească");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 740,
                column: "Name",
                value: "Molești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 741,
                column: "Name",
                value: "Movileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 742,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 743,
                column: "Name",
                value: "Petrunea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 744,
                column: "Name",
                value: "Serghieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 745,
                column: "Name",
                value: "Soroca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 746,
                column: "Name",
                value: "Stîrcea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 747,
                column: "Name",
                value: "Sturzovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 748,
                column: "Name",
                value: "Tomeștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 749,
                column: "Name",
                value: "Tomeștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 750,
                column: "Name",
                value: "Ustia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Viișoara" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 752,
                column: "Name",
                value: "Anini");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 753,
                column: "Name",
                value: "Bălceana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 754,
                column: "Name",
                value: "Bobeica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 755,
                column: "Name",
                value: "Boghiceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 756,
                column: "Name",
                value: "Bozieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 757,
                column: "Name",
                value: "Brătianovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 758,
                column: "Name",
                value: "Bujor");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 759,
                column: "Name",
                value: "Buțeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 760,
                column: "Name",
                value: "Caracui");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 761,
                column: "Name",
                value: "Călmățui");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 762,
                column: "Name",
                value: "Cărpineni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 763,
                column: "Name",
                value: "Cărpineanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 764,
                column: "Name",
                value: "Cățeleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 765,
                column: "Name",
                value: "Chetroșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 766,
                column: "Name",
                value: "Cioara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 767,
                column: "Name",
                value: "Ciuciuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 768,
                column: "Name",
                value: "Cornești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 769,
                column: "Name",
                value: "Coroliovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 770,
                column: "Name",
                value: "Costești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 771,
                column: "Name",
                value: "Cotul Morii");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 772,
                column: "Name",
                value: "Crasnoarmeiscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 773,
                column: "Name",
                value: "Dahnovici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 774,
                column: "Name",
                value: "Dancu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 775,
                column: "Name",
                value: "Drăgușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 776,
                column: "Name",
                value: "Drăgușenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 777,
                column: "Name",
                value: "Dubovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 778,
                column: "Name",
                value: "Feteasca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 779,
                column: "Name",
                value: "Fîrlădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 780,
                column: "Name",
                value: "Frasin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 781,
                column: "Name",
                value: "Fundul Galbenei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 782,
                column: "Name",
                value: "Hîncești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 783,
                column: "Name",
                value: "Horjești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 784,
                column: "Name",
                value: "Horodca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 785,
                column: "Name",
                value: "Ivanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Lăpușna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Leușeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Logănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Marchet" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Mereșeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Mingir" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Mirești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Negrea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Nemțeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Obileni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Onești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Pașcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Pereni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Pervomaiscoe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Pogănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Rusca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Sărata-Galbenă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Sărata-Mereșeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Sărăteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Secăreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Secărenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Semionovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Sofia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Stolniceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Strîmbeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Șipoteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Tălăiești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Valea Florii" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Voinescu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 815,
                column: "Name",
                value: "Alexandrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 816,
                column: "Name",
                value: "Bardar");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 817,
                column: "Name",
                value: "Bălțați");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 818,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 819,
                column: "Name",
                value: "Cărbuna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 820,
                column: "Name",
                value: "Cigîrleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 821,
                column: "Name",
                value: "Costești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 822,
                column: "Name",
                value: "Dănceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 823,
                column: "Name",
                value: "Gangura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 824,
                column: "Name",
                value: "Găureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 825,
                column: "Name",
                value: "Hansca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 826,
                column: "Name",
                value: "Horești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 827,
                column: "Name",
                value: "Homuteanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 828,
                column: "Name",
                value: "Horodca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 829,
                column: "Name",
                value: "Ialoveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 830,
                column: "Name",
                value: "Malcoci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 831,
                column: "Name",
                value: "Mileștii Mici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 832,
                column: "Name",
                value: "Mileștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 833,
                column: "Name",
                value: "Misovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 834,
                column: "Name",
                value: "Molești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 835,
                column: "Name",
                value: "Nimoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 836,
                column: "Name",
                value: "Piatra Albă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 837,
                column: "Name",
                value: "Pojăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 838,
                column: "Name",
                value: "Puhoi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 839,
                column: "Name",
                value: "Răzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 840,
                column: "Name",
                value: "Ruseștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 841,
                column: "Name",
                value: "Ruseștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 842,
                column: "Name",
                value: "Sociteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 843,
                column: "Name",
                value: "Suruceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 844,
                column: "Name",
                value: "Țipala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 845,
                column: "Name",
                value: "Ulmu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 846,
                column: "Name",
                value: "Văratic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 847,
                column: "Name",
                value: "Văsieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 848,
                column: "Name",
                value: "Zîmbreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 849,
                column: "Name",
                value: "Băiuș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 850,
                column: "Name",
                value: "Beștemac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 851,
                column: "Name",
                value: "Borogani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 852,
                column: "Name",
                value: "Bulgărica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 853,
                column: "Name",
                value: "Cazangic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 854,
                column: "Name",
                value: "Ceadîr");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 855,
                column: "Name",
                value: "Cîmpul Drept");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 856,
                column: "Name",
                value: "Cîzlar");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 857,
                column: "Name",
                value: "Cneazevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 858,
                column: "Name",
                value: "Cociulia Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 859,
                column: "Name",
                value: "Colibabovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 860,
                column: "Name",
                value: "Covurlui");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 861,
                column: "Name",
                value: "Cupcui");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 862,
                column: "Name",
                value: "Cuporani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 863,
                column: "Name",
                value: "Filipeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 864,
                column: "Name",
                value: "Frumușica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 865,
                column: "Name",
                value: "Hănăsenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 866,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 867,
                column: "Name",
                value: "Iargara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 868,
                column: "Name",
                value: "Leova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 869,
                column: "Name",
                value: "Meșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 870,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 871,
                column: "Name",
                value: "Orac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 872,
                column: "Name",
                value: "Pitești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 873,
                column: "Name",
                value: "Romanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 874,
                column: "Name",
                value: "Sărata Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 875,
                column: "Name",
                value: "Sărata-Răzeși");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 876,
                column: "Name",
                value: "Sărăteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 877,
                column: "Name",
                value: "Sărățica Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 878,
                column: "Name",
                value: "Sărățica Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 879,
                column: "Name",
                value: "Seliște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 880,
                column: "Name",
                value: "Sîrma");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 881,
                column: "Name",
                value: "Tigheci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 882,
                column: "Name",
                value: "Tochile-Răducani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 23, "Tomai" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 23, "Tomaiul Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 23, "Troian" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 23, "Troița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 23, "Victoria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 23, "Vozneseni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 889,
                column: "Name",
                value: "Băcșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 890,
                column: "Name",
                value: "Bălănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 891,
                column: "Name",
                value: "Bălăurești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 892,
                column: "Name",
                value: "Bărboieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 893,
                column: "Name",
                value: "Boldurești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 894,
                column: "Name",
                value: "Bolțun");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 895,
                column: "Name",
                value: "Brătuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 896,
                column: "Name",
                value: "Bursuc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 897,
                column: "Name",
                value: "Călimănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 898,
                column: "Name",
                value: "Chilișoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 899,
                column: "Name",
                value: "Ciorești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 900,
                column: "Name",
                value: "Ciutești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 901,
                column: "Name",
                value: "Cîrnești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 902,
                column: "Name",
                value: "Cristești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 903,
                column: "Name",
                value: "Drojdieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 904,
                column: "Name",
                value: "Găureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 905,
                column: "Name",
                value: "Grozești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 906,
                column: "Name",
                value: "Heleșteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 907,
                column: "Name",
                value: "Isăicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 908,
                column: "Name",
                value: "Iurceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 909,
                column: "Name",
                value: "Luminița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 910,
                column: "Name",
                value: "Marinici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 911,
                column: "Name",
                value: "Milești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 912,
                column: "Name",
                value: "Mîrzoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 913,
                column: "Name",
                value: "Nisporeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 914,
                column: "Name",
                value: "Odaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 915,
                column: "Name",
                value: "Odobești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 916,
                column: "Name",
                value: "Păruceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 917,
                column: "Name",
                value: "Seliște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 918,
                column: "Name",
                value: "Soltănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 920,
                column: "Name",
                value: "Șendreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 921,
                column: "Name",
                value: "Șișcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Valea Nîrnovei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Valea-Trestieni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Vărzărești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Vînători" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Vulcănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Zberoaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 928,
                column: "Name",
                value: "Berezovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 929,
                column: "Name",
                value: "Bîrlădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 930,
                column: "Name",
                value: "Bîrnova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 931,
                column: "Name",
                value: "Călărașeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 932,
                column: "Name",
                value: "Clocușna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 933,
                column: "Name",
                value: "Codreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 934,
                column: "Name",
                value: "Corestăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 935,
                column: "Name",
                value: "Dîngeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 936,
                column: "Name",
                value: "Frunză");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 937,
                column: "Name",
                value: "Gîrbova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 938,
                column: "Name",
                value: "Grinăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 939,
                column: "Name",
                value: "Grinăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 940,
                column: "Name",
                value: "Grinăuți-Moldova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 941,
                column: "Name",
                value: "Grinăuți-Raia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 942,
                column: "Name",
                value: "Hădărăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 943,
                column: "Name",
                value: "Lencăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 944,
                column: "Name",
                value: "Lipnic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 945,
                column: "Name",
                value: "Maiovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 946,
                column: "Name",
                value: "Mereșeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 947,
                column: "Name",
                value: "Mihălășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 948,
                column: "Name",
                value: "Naslavcea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 949,
                column: "Name",
                value: "Ocnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 950,
                column: "Name",
                value: "Ocnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 951,
                column: "Name",
                value: "Otaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 952,
                column: "Name",
                value: "Paladea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 953,
                column: "Name",
                value: "Paustova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 954,
                column: "Name",
                value: "Rediul Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Rujnița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Sauca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Stălinești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Unguri" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Vălcineț" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Verejeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 961,
                column: "Name",
                value: "Andreevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 962,
                column: "Name",
                value: "Berezlogi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 963,
                column: "Name",
                value: "Biești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 964,
                column: "Name",
                value: "Bolohan");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 965,
                column: "Name",
                value: "Brănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 966,
                column: "Name",
                value: "Brăviceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 967,
                column: "Name",
                value: "Breanova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 968,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 969,
                column: "Name",
                value: "Bulăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 970,
                column: "Name",
                value: "Butuceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 971,
                column: "Name",
                value: "Camencea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 972,
                column: "Name",
                value: "Chiperceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 973,
                column: "Name",
                value: "Cihoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 974,
                column: "Name",
                value: "Ciocîlteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 975,
                column: "Name",
                value: "Cișmea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 976,
                column: "Name",
                value: "Clișova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 977,
                column: "Name",
                value: "Clișova Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 978,
                column: "Name",
                value: "Crihana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 979,
                column: "Name",
                value: "Cucuruzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 980,
                column: "Name",
                value: "Cucuruzenii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 981,
                column: "Name",
                value: "Curchi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 982,
                column: "Name",
                value: "Dișcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 983,
                column: "Name",
                value: "Donici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 984,
                column: "Name",
                value: "Fedoreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 985,
                column: "Name",
                value: "Furceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 986,
                column: "Name",
                value: "Ghetlova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 987,
                column: "Name",
                value: "Hîjdieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 988,
                column: "Name",
                value: "Hulboaca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 989,
                column: "Name",
                value: "Inculeț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 990,
                column: "Name",
                value: "Isacova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 991,
                column: "Name",
                value: "Ivancea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 992,
                column: "Name",
                value: "Izvoare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 993,
                column: "Name",
                value: "Jeloboc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 994,
                column: "Name",
                value: "Jora de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 995,
                column: "Name",
                value: "Jora de Mijloc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 996,
                column: "Name",
                value: "Jora de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 997,
                column: "Name",
                value: "Jeloboc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 998,
                column: "Name",
                value: "Lopatna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 999,
                column: "Name",
                value: "Lucășeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Name",
                value: "Mana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Name",
                value: "Mălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Name",
                value: "Mitoc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1003,
                column: "Name",
                value: "Mîrzaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1004,
                column: "Name",
                value: "Mîrzești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1005,
                column: "Name",
                value: "Morovaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1006,
                column: "Name",
                value: "Morozeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1007,
                column: "Name",
                value: "Neculăieuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1008,
                column: "Name",
                value: "Noroceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1009,
                column: "Name",
                value: "Ocnița-Răzeși");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Name",
                value: "Ocnița-Țărani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1011,
                column: "Name",
                value: "Orhei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1012,
                column: "Name",
                value: "Pelivan");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1013,
                column: "Name",
                value: "Peresecina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1014,
                column: "Name",
                value: "Piatra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1015,
                column: "Name",
                value: "Pocșești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1016,
                column: "Name",
                value: "Podgoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1017,
                column: "Name",
                value: "Pohorniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1018,
                column: "Name",
                value: "Pohrebeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1019,
                column: "Name",
                value: "Puțintei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1020,
                column: "Name",
                value: "Sămănanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1021,
                column: "Name",
                value: "Seliște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1022,
                column: "Name",
                value: "Sirota");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1023,
                column: "Name",
                value: "Slobozia-Hodorogea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1024,
                column: "Name",
                value: "Step-Soci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1025,
                column: "Name",
                value: "Susleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1026,
                column: "Name",
                value: "Șercani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1027,
                column: "Name",
                value: "Tabăra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1028,
                column: "Name",
                value: "Teleșeu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1029,
                column: "Name",
                value: "Tîrzieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1030,
                column: "Name",
                value: "Trebujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Vatici" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Vîprova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Vîșcăuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Voroteț" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Zahoreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Zorile" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1037,
                column: "Name",
                value: "Boșernița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1038,
                column: "Name",
                value: "Buciușca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1039,
                column: "Name",
                value: "Bușăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1040,
                column: "Name",
                value: "Cinișeuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1041,
                column: "Name",
                value: "Ciorna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1042,
                column: "Name",
                value: "Cogîlniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1043,
                column: "Name",
                value: "Cuizăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1044,
                column: "Name",
                value: "Echimăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1045,
                column: "Name",
                value: "Ghiduleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1046,
                column: "Name",
                value: "Gordinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1047,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1048,
                column: "Name",
                value: "Ignăței");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1049,
                column: "Name",
                value: "Lalova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1050,
                column: "Name",
                value: "Lipceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1051,
                column: "Name",
                value: "Mateuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1052,
                column: "Name",
                value: "Meșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1053,
                column: "Name",
                value: "Mincenii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1054,
                column: "Name",
                value: "Mincenii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1055,
                column: "Name",
                value: "Nistreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1056,
                column: "Name",
                value: "Otac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1057,
                column: "Name",
                value: "Păpăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1058,
                column: "Name",
                value: "Peciște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1059,
                column: "Name",
                value: "Pereni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1060,
                column: "Name",
                value: "Piscărești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1061,
                column: "Name",
                value: "Pripiceni-Curchi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1062,
                column: "Name",
                value: "Pripiceni-Răzeși");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1063,
                column: "Name",
                value: "Rezina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1064,
                column: "Name",
                value: "Roșcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1065,
                column: "Name",
                value: "Roșcanii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1066,
                column: "Name",
                value: "Roșcanii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1067,
                column: "Name",
                value: "Saharna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1068,
                column: "Name",
                value: "Saharna Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1069,
                column: "Name",
                value: "Sîrcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1070,
                column: "Name",
                value: "Slobozia-Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1071,
                column: "Name",
                value: "Solonceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Stohnaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Tarasova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Trifești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Țahnăuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Țareuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Țipova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1078,
                column: "Name",
                value: "Alexăndrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1079,
                column: "Name",
                value: "Aluniș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1080,
                column: "Name",
                value: "Armanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1081,
                column: "Name",
                value: "Avrămeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1082,
                column: "Name",
                value: "Bălanu Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1083,
                column: "Name",
                value: "Borosenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1084,
                column: "Name",
                value: "Braniște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1085,
                column: "Name",
                value: "Bulhac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1086,
                column: "Name",
                value: "Cepăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1087,
                column: "Name",
                value: "Ciobanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1088,
                column: "Name",
                value: "Corlăteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1089,
                column: "Name",
                value: "Costești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1090,
                column: "Name",
                value: "Cucuieții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1091,
                column: "Name",
                value: "Cucuieții Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1092,
                column: "Name",
                value: "Dămășcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1093,
                column: "Name",
                value: "Druța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1094,
                column: "Name",
                value: "Dumeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1095,
                column: "Name",
                value: "Duruitoarea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Name",
                value: "Duruitoarea Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1097,
                column: "Name",
                value: "Gălășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1098,
                column: "Name",
                value: "Grinăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1099,
                column: "Name",
                value: "Hiliuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1100,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1101,
                column: "Name",
                value: "Ivănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1102,
                column: "Name",
                value: "Lupăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1103,
                column: "Name",
                value: "Malinovscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1104,
                column: "Name",
                value: "Mălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1105,
                column: "Name",
                value: "Mihălășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1106,
                column: "Name",
                value: "Mihăilenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1107,
                column: "Name",
                value: "Moșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1108,
                column: "Name",
                value: "Nihoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1109,
                column: "Name",
                value: "Păscăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1110,
                column: "Name",
                value: "Petrușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1111,
                column: "Name",
                value: "Pîrjota");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1112,
                column: "Name",
                value: "Pociumbăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1113,
                column: "Name",
                value: "Pociumbeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1114,
                column: "Name",
                value: "Proscureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1115,
                column: "Name",
                value: "Răcăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1116,
                column: "Name",
                value: "Rămăzan");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1117,
                column: "Name",
                value: "Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1118,
                column: "Name",
                value: "Reteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1119,
                column: "Name",
                value: "Reteni-Vasileuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1120,
                column: "Name",
                value: "Rîșcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1121,
                column: "Name",
                value: "Singureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Name",
                value: "Slobozia-Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1123,
                column: "Name",
                value: "Sturzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1124,
                column: "Name",
                value: "Sverdiac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1125,
                column: "Name",
                value: "Șaptebani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Știubeieni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Șumna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Ușurei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Vasileuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Văratic" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Zăicani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1132,
                column: "Name",
                value: "Alexăndreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1133,
                column: "Name",
                value: "Alexeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1134,
                column: "Name",
                value: "Antonovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1135,
                column: "Name",
                value: "Bălășești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1136,
                column: "Name",
                value: "Bilicenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1137,
                column: "Name",
                value: "Bilicenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1138,
                column: "Name",
                value: "Biruința");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1139,
                column: "Name",
                value: "Bobletici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1140,
                column: "Name",
                value: "Bocancea-Schit");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1141,
                column: "Name",
                value: "Brejeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1142,
                column: "Name",
                value: "Bursuceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1143,
                column: "Name",
                value: "Chirileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1144,
                column: "Name",
                value: "Chișcăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1145,
                column: "Name",
                value: "Ciuciuieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1146,
                column: "Name",
                value: "Clișcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1147,
                column: "Name",
                value: "Coada Iazului");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1148,
                column: "Name",
                value: "Copăceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1149,
                column: "Name",
                value: "Coșcodeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1150,
                column: "Name",
                value: "Cotiujenii Mici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1151,
                column: "Name",
                value: "Cotovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1152,
                column: "Name",
                value: "Cozești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1153,
                column: "Name",
                value: "Cubolta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1154,
                column: "Name",
                value: "Dobrogea Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1155,
                column: "Name",
                value: "Dobrogea Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1156,
                column: "Name",
                value: "Drăgănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1157,
                column: "Name",
                value: "Dumbrăvița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1158,
                column: "Name",
                value: "Evghenievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1159,
                column: "Name",
                value: "Flămînzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1160,
                column: "Name",
                value: "Gavrilovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1161,
                column: "Name",
                value: "Grigorăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1162,
                column: "Name",
                value: "Grigorești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1163,
                column: "Name",
                value: "Gura-Oituz");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1164,
                column: "Name",
                value: "Heciul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1165,
                column: "Name",
                value: "Heciul Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1166,
                column: "Name",
                value: "Iezărenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1167,
                column: "Name",
                value: "Iezărenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1168,
                column: "Name",
                value: "Izvoare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1169,
                column: "Name",
                value: "Lipovanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1170,
                column: "Name",
                value: "Mărășești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1171,
                column: "Name",
                value: "Mărinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1172,
                column: "Name",
                value: "Mihailovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1173,
                column: "Name",
                value: "Mîndreștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1174,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1175,
                column: "Name",
                value: "Octeabriscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1176,
                column: "Name",
                value: "Pălăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1177,
                column: "Name",
                value: "Pepeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1178,
                column: "Name",
                value: "Pepenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1179,
                column: "Name",
                value: "Petrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1180,
                column: "Name",
                value: "Petropavlovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1181,
                column: "Name",
                value: "Prepelița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1182,
                column: "Name",
                value: "Rădoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1183,
                column: "Name",
                value: "Răzălăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1184,
                column: "Name",
                value: "Romanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1185,
                column: "Name",
                value: "Sacarovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1186,
                column: "Name",
                value: "Sîngerei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1187,
                column: "Name",
                value: "Sîngereii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1188,
                column: "Name",
                value: "Slobozia-Chișcăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1189,
                column: "Name",
                value: "Slobozia-Măgura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1190,
                column: "Name",
                value: "Sloveanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1191,
                column: "Name",
                value: "Șestaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1192,
                column: "Name",
                value: "Tăura Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1193,
                column: "Name",
                value: "Tăura Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1194,
                column: "Name",
                value: "Trifănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1195,
                column: "Name",
                value: "Țambula");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Țiplești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Țipletești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Valea lui Vlad" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Valea Norocului" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Vladimireuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Vrănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1202,
                column: "Name",
                value: "Alexandru cel Bun");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1203,
                column: "Name",
                value: "Balinți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1204,
                column: "Name",
                value: "Balinții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1205,
                column: "Name",
                value: "Bădiceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1206,
                column: "Name",
                value: "Băxani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1207,
                column: "Name",
                value: "Bulboci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1208,
                column: "Name",
                value: "Bulbocii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1209,
                column: "Name",
                value: "Căinarii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1210,
                column: "Name",
                value: "Cerlina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1211,
                column: "Name",
                value: "Cosăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1212,
                column: "Name",
                value: "Cremenciug");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1213,
                column: "Name",
                value: "Cureșnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1214,
                column: "Name",
                value: "Cureșnița Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1215,
                column: "Name",
                value: "Dărcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1216,
                column: "Name",
                value: "Dărcăuții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1217,
                column: "Name",
                value: "Decebal");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1218,
                column: "Name",
                value: "Dubna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1219,
                column: "Name",
                value: "Dumbrăveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1220,
                column: "Name",
                value: "Egoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1221,
                column: "Name",
                value: "Floriceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1222,
                column: "Name",
                value: "Grigorăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1223,
                column: "Name",
                value: "Holoșnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1224,
                column: "Name",
                value: "Hristici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1225,
                column: "Name",
                value: "Iarova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1226,
                column: "Name",
                value: "Iorjnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1227,
                column: "Name",
                value: "Inundeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1228,
                column: "Name",
                value: "Livezi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1229,
                column: "Name",
                value: "Lugovoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1230,
                column: "Name",
                value: "Mălcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1231,
                column: "Name",
                value: "Nimereuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1232,
                column: "Name",
                value: "Niorcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1233,
                column: "Name",
                value: "Oclanda");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1234,
                column: "Name",
                value: "Ocolina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1235,
                column: "Name",
                value: "Parcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1236,
                column: "Name",
                value: "Pîrlița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1237,
                column: "Name",
                value: "Racovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1238,
                column: "Name",
                value: "Redi-Cereșnovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1239,
                column: "Name",
                value: "Regina Maria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1240,
                column: "Name",
                value: "Rublenița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1241,
                column: "Name",
                value: "Rublenița Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1242,
                column: "Name",
                value: "Ruslanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1243,
                column: "Name",
                value: "Rudi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1244,
                column: "Name",
                value: "Schineni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1245,
                column: "Name",
                value: "Schinenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1246,
                column: "Name",
                value: "Slobozia-Cremene");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1247,
                column: "Name",
                value: "Slobozia Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1248,
                column: "Name",
                value: "Slobozia-Vărăncău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1249,
                column: "Name",
                value: "Sobari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1250,
                column: "Name",
                value: "Soloneț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1251,
                column: "Name",
                value: "Soroca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1252,
                column: "Name",
                value: "Stoicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1253,
                column: "Name",
                value: "Șeptelici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1254,
                column: "Name",
                value: "Șolcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1255,
                column: "Name",
                value: "Tătărăuca Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1256,
                column: "Name",
                value: "Tolocănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1257,
                column: "Name",
                value: "Trifăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1258,
                column: "Name",
                value: "Țepilova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1259,
                column: "Name",
                value: "Valea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1260,
                column: "Name",
                value: "Vanțina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1261,
                column: "Name",
                value: "Vanțina Mică");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1262,
                column: "Name",
                value: "Vasilcău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Vărăncău" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1264,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Vădeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1265,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Visoca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1266,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Voloave" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1267,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Volovița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1268,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Zastînca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1269,
                column: "Name",
                value: "Bucovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1270,
                column: "Name",
                value: "Căpriana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1271,
                column: "Name",
                value: "Chirianca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1272,
                column: "Name",
                value: "Ciobanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1273,
                column: "Name",
                value: "Codreanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1274,
                column: "Name",
                value: "Cojușna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1275,
                column: "Name",
                value: "Dolna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1276,
                column: "Name",
                value: "Drăgușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1277,
                column: "Name",
                value: "Făgureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1278,
                column: "Name",
                value: "Gălești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1279,
                column: "Name",
                value: "Găleștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1280,
                column: "Name",
                value: "Ghelăuza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1281,
                column: "Name",
                value: "Gornoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1282,
                column: "Name",
                value: "Greblești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1283,
                column: "Name",
                value: "Huzun");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1284,
                column: "Name",
                value: "Lozova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1285,
                column: "Name",
                value: "Lupa-Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1286,
                column: "Name",
                value: "Mărtinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1287,
                column: "Name",
                value: "Micăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1288,
                column: "Name",
                value: "Micleușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1289,
                column: "Name",
                value: "Negrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1290,
                column: "Name",
                value: "Onești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1291,
                column: "Name",
                value: "Pănășești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1292,
                column: "Name",
                value: "Rassvet");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1293,
                column: "Name",
                value: "Rădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1294,
                column: "Name",
                value: "Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1295,
                column: "Name",
                value: "Romănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1296,
                column: "Name",
                value: "Roșcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1297,
                column: "Name",
                value: "Saca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1298,
                column: "Name",
                value: "Scoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1299,
                column: "Name",
                value: "Sireți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Name",
                value: "Stejăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1301,
                column: "Name",
                value: "Strășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1302,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Tătărești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Țigănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Voinova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Vorniceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Zamciogi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Zubrești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1308,
                column: "Name",
                value: "Alcedar");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1309,
                column: "Name",
                value: "Chipeșca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1310,
                column: "Name",
                value: "Climăuții de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1311,
                column: "Name",
                value: "Cobîlea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1312,
                column: "Name",
                value: "Cot");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1313,
                column: "Name",
                value: "Cotiujenii Mari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1314,
                column: "Name",
                value: "Curătura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1315,
                column: "Name",
                value: "Cușelăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1316,
                column: "Name",
                value: "Cușmirca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1317,
                column: "Name",
                value: "Dobrușa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1318,
                column: "Name",
                value: "Fuzăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1319,
                column: "Name",
                value: "Găuzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1320,
                column: "Name",
                value: "Glinjeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1321,
                column: "Name",
                value: "Lelina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1322,
                column: "Name",
                value: "Mihuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1323,
                column: "Name",
                value: "Odaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1324,
                column: "Name",
                value: "Olișcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1325,
                column: "Name",
                value: "Parcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1326,
                column: "Name",
                value: "Pohoarna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1327,
                column: "Name",
                value: "Poiana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1328,
                column: "Name",
                value: "Răspopeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1329,
                column: "Name",
                value: "Recești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1330,
                column: "Name",
                value: "Rogojeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1331,
                column: "Name",
                value: "Salcia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1332,
                column: "Name",
                value: "Sămășcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1333,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Zahorna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1334,
                column: "Name",
                value: "Alava");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1335,
                column: "Name",
                value: "Antonești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1336,
                column: "Name",
                value: "Brezoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1337,
                column: "Name",
                value: "Carahasani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1338,
                column: "Name",
                value: "Căplani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1339,
                column: "Name",
                value: "Cioburciu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1340,
                column: "Name",
                value: "Copceac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1341,
                column: "Name",
                value: "Crocmaz");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1342,
                column: "Name",
                value: "Ermoclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1343,
                column: "Name",
                value: "Feștelița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1344,
                column: "Name",
                value: "Lazo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1345,
                column: "Name",
                value: "Marianca de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1346,
                column: "Name",
                value: "Olănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1347,
                column: "Name",
                value: "Palanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1348,
                column: "Name",
                value: "Popeasca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1349,
                column: "Name",
                value: "Purcari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1350,
                column: "Name",
                value: "Răscăieți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1351,
                column: "Name",
                value: "Răscăieții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1352,
                column: "Name",
                value: "Semionovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1353,
                column: "Name",
                value: "Slobozia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1354,
                column: "Name",
                value: "Ștefan Vodă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1355,
                column: "Name",
                value: "Ștefănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1356,
                column: "Name",
                value: "Talmaza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1357,
                column: "Name",
                value: "Tudora");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1358,
                column: "Name",
                value: "Viișoara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 33, "Volintiri" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1360,
                column: "Name",
                value: "Albota de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1361,
                column: "Name",
                value: "Albota de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1362,
                column: "Name",
                value: "Aluatu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1363,
                column: "Name",
                value: "Balabanu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1364,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1365,
                column: "Name",
                value: "Cairaclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1366,
                column: "Name",
                value: "Cealîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1367,
                column: "Name",
                value: "Ciumai");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1368,
                column: "Name",
                value: "Chirilovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1369,
                column: "Name",
                value: "Corten");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1370,
                column: "Name",
                value: "Cortenul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1371,
                column: "Name",
                value: "Dermengi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1372,
                column: "Name",
                value: "Hagichioi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1373,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1374,
                column: "Name",
                value: "Mirnoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1375,
                column: "Name",
                value: "Musaitu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1376,
                column: "Name",
                value: "Novosiolovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1377,
                column: "Name",
                value: "Orehovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1378,
                column: "Name",
                value: "Roșița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1379,
                column: "Name",
                value: "Salcia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1380,
                column: "Name",
                value: "Samurza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1381,
                column: "Name",
                value: "Sofievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1382,
                column: "Name",
                value: "Taraclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1383,
                column: "Name",
                value: "Tvardița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1384,
                column: "Name",
                value: "Valea Perjei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 34, "Vinogradovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1386,
                column: "Name",
                value: "Bănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1387,
                column: "Name",
                value: "Băneștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1388,
                column: "Name",
                value: "Bogzești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1389,
                column: "Name",
                value: "Bondareuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1390,
                column: "Name",
                value: "Brînzenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1391,
                column: "Name",
                value: "Brînzenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1392,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1393,
                column: "Name",
                value: "Căzănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1394,
                column: "Name",
                value: "Chersac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1395,
                column: "Name",
                value: "Chiștelnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1396,
                column: "Name",
                value: "Chițcanii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1397,
                column: "Name",
                value: "Chițcanii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1398,
                column: "Name",
                value: "Ciofu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1399,
                column: "Name",
                value: "Ciulucani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Name",
                value: "Cîșla");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1401,
                column: "Name",
                value: "Codru");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1402,
                column: "Name",
                value: "Codrul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1403,
                column: "Name",
                value: "Coropceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1404,
                column: "Name",
                value: "Crăsnășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1405,
                column: "Name",
                value: "Cucioaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1406,
                column: "Name",
                value: "Cucioaia Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1407,
                column: "Name",
                value: "Dobrușa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1408,
                column: "Name",
                value: "Flutura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1409,
                column: "Name",
                value: "Ghermănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1410,
                column: "Name",
                value: "Ghiliceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1411,
                column: "Name",
                value: "Hirișeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1412,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1413,
                column: "Name",
                value: "Inești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1414,
                column: "Name",
                value: "Leușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1415,
                column: "Name",
                value: "Mihălașa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1416,
                column: "Name",
                value: "Mihălașa Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1417,
                column: "Name",
                value: "Mîndra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1418,
                column: "Name",
                value: "Mîndrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1419,
                column: "Name",
                value: "Negureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1420,
                column: "Name",
                value: "Nucăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1421,
                column: "Name",
                value: "Ordășei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1422,
                column: "Name",
                value: "Pistruieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1423,
                column: "Name",
                value: "Pistruienii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1424,
                column: "Name",
                value: "Ratuș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1425,
                column: "Name",
                value: "Sărătenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1426,
                column: "Name",
                value: "Sărătenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1427,
                column: "Name",
                value: "Scorțeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1428,
                column: "Name",
                value: "Suhuluceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1429,
                column: "Name",
                value: "Telenești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1430,
                column: "Name",
                value: "Tîrșiței");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1431,
                column: "Name",
                value: "Țînțăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1432,
                column: "Name",
                value: "Vadul-Leca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1433,
                column: "Name",
                value: "Vadul-Leca Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1434,
                column: "Name",
                value: "Văsieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1435,
                column: "Name",
                value: "Verejeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1436,
                column: "Name",
                value: "Zahareuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1437,
                column: "Name",
                value: "Zăicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1438,
                column: "Name",
                value: "Zăicanii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 35, "Zgărdești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1440,
                column: "Name",
                value: "Agronomovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1441,
                column: "Name",
                value: "Alexeevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1442,
                column: "Name",
                value: "Blindești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1443,
                column: "Name",
                value: "Boghenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1444,
                column: "Name",
                value: "Boghenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1445,
                column: "Name",
                value: "Buciumeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1446,
                column: "Name",
                value: "Bulhac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1447,
                column: "Name",
                value: "Bumbăta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1448,
                column: "Name",
                value: "Bușila");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1449,
                column: "Name",
                value: "Buzduganii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1450,
                column: "Name",
                value: "Buzduganii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1451,
                column: "Name",
                value: "Cetireni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1452,
                column: "Name",
                value: "Chirileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1453,
                column: "Name",
                value: "Cioropcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1454,
                column: "Name",
                value: "Condrătești");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 135,
                column: "Name",
                value: "Balasinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 136,
                column: "Name",
                value: "Bălcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 137,
                column: "Name",
                value: "Beleavinți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 138,
                column: "Name",
                value: "Berlinți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 139,
                column: "Name",
                value: "Bezeda");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 140,
                column: "Name",
                value: "Bocicăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 141,
                column: "Name",
                value: "Bogdănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 142,
                column: "Name",
                value: "Briceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 143,
                column: "Name",
                value: "Bulboaca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 144,
                column: "Name",
                value: "Caracușenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 145,
                column: "Name",
                value: "Caracușenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 146,
                column: "Name",
                value: "Chirilovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 147,
                column: "Name",
                value: "Colicăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 148,
                column: "Name",
                value: "Corjeuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 149,
                column: "Name",
                value: "Coteala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 150,
                column: "Name",
                value: "Cotiujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 151,
                column: "Name",
                value: "Criva");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 152,
                column: "Name",
                value: "Drepcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 153,
                column: "Name",
                value: "Grimești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 154,
                column: "Name",
                value: "Grimăncăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 155,
                column: "Name",
                value: "Groznița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 156,
                column: "Name",
                value: "Halahora de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 157,
                column: "Name",
                value: "Halahora de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 158,
                column: "Name",
                value: "Hlina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 159,
                column: "Name",
                value: "Larga");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 160,
                column: "Name",
                value: "Lipcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 161,
                column: "Name",
                value: "Mărcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 162,
                column: "Name",
                value: "Mărcăuții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 163,
                column: "Name",
                value: "Medveja");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 164,
                column: "Name",
                value: "Mihăileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 165,
                column: "Name",
                value: "Pavlovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 166,
                column: "Name",
                value: "Pererîta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 167,
                column: "Name",
                value: "Slobozia-Medveja");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 168,
                column: "Name",
                value: "Slobozia-Șirăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 169,
                column: "Name",
                value: "Șirăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 170,
                column: "Name",
                value: "Tabani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 171,
                column: "Name",
                value: "Tețcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 172,
                column: "Name",
                value: "Trebisăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 173,
                column: "Name",
                value: "Trestieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Alexanderfeld" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Alexandru Ioan Cuza" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Andrușul de Jos" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Andrușul de Sus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Badicul Moldovenesc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Baurci-Moldoveni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Borceag" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Bucuria" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Burlacu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Burlăceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Brînza" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Cahul" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Chioselia Mare" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Chircani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Cîșlița-Prut" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Colibași" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 190,
                column: "Name",
                value: "Cotihana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 191,
                column: "Name",
                value: "Crihana Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "Cucoara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 193,
                column: "Name",
                value: "Doina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 194,
                column: "Name",
                value: "Frumușica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 195,
                column: "Name",
                value: "Găvănoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 196,
                column: "Name",
                value: "Giurgiulești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 197,
                column: "Name",
                value: "Greceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 198,
                column: "Name",
                value: "Huluboaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 199,
                column: "Name",
                value: "Hutulu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 200,
                column: "Name",
                value: "Iasnaia Poleana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 201,
                column: "Name",
                value: "Iujnoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 202,
                column: "Name",
                value: "Larga Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Larga Veche" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Lebedenco" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Lopățica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Lucești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Manta" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Moscovei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Nicolaevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Paicu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Pașcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Pelinei" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Roșu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Rumeanțev" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Sătuc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Slobozia Mare" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Spicoasa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Taraclia de Salcie" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Tartaul de Salcie" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Tătărești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Tretești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Trifeștii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Tudorești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Ursoaia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Vadul lui Isac" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Văleni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Vladimirovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 8, "Zîrnești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 229,
                column: "Name",
                value: "Camenca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 230,
                column: "Name",
                value: "Caterinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 231,
                column: "Name",
                value: "Crasnîi Octeabri");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 232,
                column: "Name",
                value: "Cuzmin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 233,
                column: "Name",
                value: "Hristovaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 234,
                column: "Name",
                value: "Hrușca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 235,
                column: "Name",
                value: "Ocnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 236,
                column: "Name",
                value: "Podoima");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 237,
                column: "Name",
                value: "Rașcov");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 238,
                column: "Name",
                value: "Rotari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 239,
                column: "Name",
                value: "Severinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 240,
                column: "Name",
                value: "Slobozia-Rașcov");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 241,
                column: "Name",
                value: "Valea Adîncă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Bahmut" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Bahu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Bravicea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Buda" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 10, "Bularda" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 247,
                column: "Name",
                value: "Căbăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 248,
                column: "Name",
                value: "Călărași");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 249,
                column: "Name",
                value: "Dereneu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 250,
                column: "Name",
                value: "Duma");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 251,
                column: "Name",
                value: "Frumoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 252,
                column: "Name",
                value: "Hirova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 253,
                column: "Name",
                value: "Hîrbovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 254,
                column: "Name",
                value: "Hîrjauca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 255,
                column: "Name",
                value: "Hoginești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 257,
                column: "Name",
                value: "Leordoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 258,
                column: "Name",
                value: "Meleșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 259,
                column: "Name",
                value: "Mîndra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 260,
                column: "Name",
                value: "Nișcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 261,
                column: "Name",
                value: "Novaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 262,
                column: "Name",
                value: "Onișcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 263,
                column: "Name",
                value: "Oricova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 264,
                column: "Name",
                value: "Palanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 265,
                column: "Name",
                value: "Parcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 266,
                column: "Name",
                value: "Păulești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 267,
                column: "Name",
                value: "Peticeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 268,
                column: "Name",
                value: "Pitușca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 269,
                column: "Name",
                value: "Pîrjolteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 270,
                column: "Name",
                value: "Podul Lung");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 271,
                column: "Name",
                value: "Răciula");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 272,
                column: "Name",
                value: "Rădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 273,
                column: "Name",
                value: "Sadova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 274,
                column: "Name",
                value: "Săseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 275,
                column: "Name",
                value: "Schinoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 276,
                column: "Name",
                value: "Seliștea Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 277,
                column: "Name",
                value: "Sipoteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 278,
                column: "Name",
                value: "Sverida");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 279,
                column: "Name",
                value: "Temeleuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 280,
                column: "Name",
                value: "Tuzara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 281,
                column: "Name",
                value: "Țibirica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 282,
                column: "Name",
                value: "Ursari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 283,
                column: "Name",
                value: "Vălcineț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 284,
                column: "Name",
                value: "Vărzăreștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Acui" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Alexandrovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Antonești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Baimaclia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Bobocica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Cania" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Cantemir" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Capaclia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Chioselia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Ciobalaccia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Cîietu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 11, "Cîrpești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 297,
                column: "Name",
                value: "Cîșla");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 298,
                column: "Name",
                value: "Crăciun");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 299,
                column: "Name",
                value: "Cociulia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 300,
                column: "Name",
                value: "Constantinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 301,
                column: "Name",
                value: "Coștangalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 302,
                column: "Name",
                value: "Dimitrova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 303,
                column: "Name",
                value: "Enichioi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 304,
                column: "Name",
                value: "Flocoasa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 305,
                column: "Name",
                value: "Floricica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 306,
                column: "Name",
                value: "Ghioltosu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 307,
                column: "Name",
                value: "Gotești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 308,
                column: "Name",
                value: "Haragîș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 309,
                column: "Name",
                value: "Hănăseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 310,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 311,
                column: "Name",
                value: "Iepureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 312,
                column: "Name",
                value: "Lărguța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 313,
                column: "Name",
                value: "Leca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 314,
                column: "Name",
                value: "Lingura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 315,
                column: "Name",
                value: "Pleșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 316,
                column: "Name",
                value: "Plopi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 317,
                column: "Name",
                value: "Popovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 318,
                column: "Name",
                value: "Porumbești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 319,
                column: "Name",
                value: "Sadîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 320,
                column: "Name",
                value: "Stoianovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 321,
                column: "Name",
                value: "Suhat");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 322,
                column: "Name",
                value: "Șamalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 323,
                column: "Name",
                value: "Șofranovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 324,
                column: "Name",
                value: "Taraclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 325,
                column: "Name",
                value: "Taraclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 326,
                column: "Name",
                value: "Tartaul");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 327,
                column: "Name",
                value: "Tătărășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 328,
                column: "Name",
                value: "Toceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 329,
                column: "Name",
                value: "Țărăncuța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 330,
                column: "Name",
                value: "Țiganca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 331,
                column: "Name",
                value: "Țiganca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 332,
                column: "Name",
                value: "Țolica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 333,
                column: "Name",
                value: "Victorovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 334,
                column: "Name",
                value: "Vișniovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 335,
                column: "Name",
                value: "Vîlcele");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Baccealia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Baimaclia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Baurci" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Căinari" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Căușeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Chircăiești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Chircăieștii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Chițcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 12, "Ciuflești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 345,
                column: "Name",
                value: "Cîrnățeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 346,
                column: "Name",
                value: "Cîrnățenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 347,
                column: "Name",
                value: "Constantinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 348,
                column: "Name",
                value: "Copanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 349,
                column: "Name",
                value: "Coșcalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 350,
                column: "Name",
                value: "Cremenciug");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 351,
                column: "Name",
                value: "Fîrlădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 352,
                column: "Name",
                value: "Fîrlădenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 353,
                column: "Name",
                value: "Florica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 354,
                column: "Name",
                value: "Gîsca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 355,
                column: "Name",
                value: "Grădinița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 356,
                column: "Name",
                value: "Grigorievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 357,
                column: "Name",
                value: "Hagimus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 358,
                column: "Name",
                value: "Leuntea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 359,
                column: "Name",
                value: "Marianca de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 360,
                column: "Name",
                value: "Merenești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 361,
                column: "Name",
                value: "Opaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 362,
                column: "Name",
                value: "Pervomaisc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 363,
                column: "Name",
                value: "Plop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 364,
                column: "Name",
                value: "Plop-Știubei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 365,
                column: "Name",
                value: "Săiți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 366,
                column: "Name",
                value: "Sălcuța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 367,
                column: "Name",
                value: "Sălcuța Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 368,
                column: "Name",
                value: "Surchiceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 369,
                column: "Name",
                value: "Ștefănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 370,
                column: "Name",
                value: "Taraclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 371,
                column: "Name",
                value: "Tănătari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 372,
                column: "Name",
                value: "Tănătarii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 373,
                column: "Name",
                value: "Tocuz");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 374,
                column: "Name",
                value: "Tricolici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 375,
                column: "Name",
                value: "Ucrainca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 376,
                column: "Name",
                value: "Ursoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 377,
                column: "Name",
                value: "Ursoaia Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 378,
                column: "Name",
                value: "Valea Verde");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 379,
                column: "Name",
                value: "Zahorna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 380,
                column: "Name",
                value: "Zaim");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 381,
                column: "Name",
                value: "Zviozdocica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Albina" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 13, "Artimonovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 384,
                column: "Name",
                value: "Batîr");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 385,
                column: "Name",
                value: "Bogdanovca Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 386,
                column: "Name",
                value: "Cenac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 387,
                column: "Name",
                value: "Cimișlia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 388,
                column: "Name",
                value: "Ciucur-Mingir");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 389,
                column: "Name",
                value: "Codreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 390,
                column: "Name",
                value: "Coștangalia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 391,
                column: "Name",
                value: "Dimitrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 392,
                column: "Name",
                value: "Ecaterinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 393,
                column: "Name",
                value: "Fetița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 394,
                column: "Name",
                value: "Gradiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 395,
                column: "Name",
                value: "Gura Galbenei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 396,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 397,
                column: "Name",
                value: "Ialpug");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 398,
                column: "Name",
                value: "Ialpujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 399,
                column: "Name",
                value: "Iurievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 400,
                column: "Name",
                value: "Ivanovca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 401,
                column: "Name",
                value: "Javgur");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 402,
                column: "Name",
                value: "Lipoveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 403,
                column: "Name",
                value: "Marienfeld");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 404,
                column: "Name",
                value: "Maximeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 405,
                column: "Name",
                value: "Mereni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 406,
                column: "Name",
                value: "Mihailovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 407,
                column: "Name",
                value: "Munteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 408,
                column: "Name",
                value: "Porumbrei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 409,
                column: "Name",
                value: "Prisaca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 410,
                column: "Name",
                value: "Sagaidac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 411,
                column: "Name",
                value: "Sagaidacul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 412,
                column: "Name",
                value: "Satul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 413,
                column: "Name",
                value: "Schinoșica");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 414,
                column: "Name",
                value: "Selemet");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 415,
                column: "Name",
                value: "Suric");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 416,
                column: "Name",
                value: "Topala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 417,
                column: "Name",
                value: "Troițcoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 418,
                column: "Name",
                value: "Valea Perjei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 419,
                column: "Name",
                value: "Zloți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Bălăbănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Bălășești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Bălțata" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Bălțata de Sus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Boșcana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Chetroasa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Cimișeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 427,
                column: "Name",
                value: "Ciopleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 428,
                column: "Name",
                value: "Corjova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 429,
                column: "Name",
                value: "Coșernița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 430,
                column: "Name",
                value: "Criuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 431,
                column: "Name",
                value: "Cruglic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 432,
                column: "Name",
                value: "Dolinnoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 433,
                column: "Name",
                value: "Drăsliceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 434,
                column: "Name",
                value: "Dubăsarii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 435,
                column: "Name",
                value: "Hîrtopul Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 436,
                column: "Name",
                value: "Hîrtopul Mic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 437,
                column: "Name",
                value: "Hrușova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 438,
                column: "Name",
                value: "Ișnovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 439,
                column: "Name",
                value: "Izbiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 440,
                column: "Name",
                value: "Jevreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 441,
                column: "Name",
                value: "Logănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 442,
                column: "Name",
                value: "Mașcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 443,
                column: "Name",
                value: "Mărdăreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 444,
                column: "Name",
                value: "Măgdăcești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 445,
                column: "Name",
                value: "Mălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 446,
                column: "Name",
                value: "Mălăieștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 447,
                column: "Name",
                value: "Miclești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 448,
                column: "Name",
                value: "Ohrincea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 449,
                column: "Name",
                value: "Onițcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 450,
                column: "Name",
                value: "Pașcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 451,
                column: "Name",
                value: "Porumbeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 452,
                column: "Name",
                value: "Ratuș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 453,
                column: "Name",
                value: "Răculești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 454,
                column: "Name",
                value: "Rîșcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 455,
                column: "Name",
                value: "Sagaidac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 456,
                column: "Name",
                value: "Sagaidacul de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Slobozia-Dușca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Stețcani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Valea Coloniței" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Valea Satului" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Zăicana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 14, "Zolonceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 463,
                column: "Name",
                value: "Arionești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 464,
                column: "Name",
                value: "Baraboi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 465,
                column: "Name",
                value: "Boroseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 466,
                column: "Name",
                value: "Braicău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 467,
                column: "Name",
                value: "Briceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 468,
                column: "Name",
                value: "Briceva");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 469,
                column: "Name",
                value: "Caraiman");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 470,
                column: "Name",
                value: "Cernoleuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 471,
                column: "Name",
                value: "Climăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 472,
                column: "Name",
                value: "Codrenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 473,
                column: "Name",
                value: "Corbu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 474,
                column: "Name",
                value: "Crișcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 475,
                column: "Name",
                value: "Dondușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 476,
                column: "Name",
                value: "Dondușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 477,
                column: "Name",
                value: "Elenovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 478,
                column: "Name",
                value: "Elizavetovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 479,
                column: "Name",
                value: "Frasin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 480,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 481,
                column: "Name",
                value: "Moșana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 482,
                column: "Name",
                value: "Octeabriscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 483,
                column: "Name",
                value: "Pivniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 484,
                column: "Name",
                value: "Plop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 485,
                column: "Name",
                value: "Pocrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 486,
                column: "Name",
                value: "Rediul Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 487,
                column: "Name",
                value: "Scăieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 488,
                column: "Name",
                value: "Sudarca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 489,
                column: "Name",
                value: "Teleșeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 490,
                column: "Name",
                value: "Teleșeuca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 491,
                column: "Name",
                value: "Tîrnova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 492,
                column: "Name",
                value: "Țaul");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Antoneuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Baroncea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Baroncea Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Ceapaevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 497,
                column: "Name",
                value: "Chetrosu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 498,
                column: "Name",
                value: "Cotova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 499,
                column: "Name",
                value: "Dominteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 500,
                column: "Name",
                value: "Drochia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 501,
                column: "Name",
                value: "Drochia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 502,
                column: "Name",
                value: "Fîntînița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 503,
                column: "Name",
                value: "Gribova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 504,
                column: "Name",
                value: "Hăsnășenii Mari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 505,
                column: "Name",
                value: "Hăsnășenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 506,
                column: "Name",
                value: "Holoșnița Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 507,
                column: "Name",
                value: "Iliciovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 508,
                column: "Name",
                value: "Lazo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 509,
                column: "Name",
                value: "Maramonovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 510,
                column: "Name",
                value: "Măcăreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 511,
                column: "Name",
                value: "Miciurin");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 512,
                column: "Name",
                value: "Mîndîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 513,
                column: "Name",
                value: "Moara de Piatră");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 514,
                column: "Name",
                value: "Nicoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 515,
                column: "Name",
                value: "Ochiul Alb");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 516,
                column: "Name",
                value: "Palanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 517,
                column: "Name",
                value: "Pelinia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 518,
                column: "Name",
                value: "Pervomaiscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 519,
                column: "Name",
                value: "Petreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 520,
                column: "Name",
                value: "Popeștii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 521,
                column: "Name",
                value: "Popeștii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Popeștii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Sergheuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Sofia" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Șalvirii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Șalvirii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Șuri" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Șurii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Țarigrad" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 16, "Zgurița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 531,
                column: "Name",
                value: "Cocieri");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 532,
                column: "Name",
                value: "Corjova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 533,
                column: "Name",
                value: "Coșnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 534,
                column: "Name",
                value: "Doroțcaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 535,
                column: "Name",
                value: "Holercani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 536,
                column: "Name",
                value: "Mahala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 537,
                column: "Name",
                value: "Mărcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 538,
                column: "Name",
                value: "Molovata");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 539,
                column: "Name",
                value: "Molovata Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 540,
                column: "Name",
                value: "Oxentea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 541,
                column: "Name",
                value: "Pîrîta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 542,
                column: "Name",
                value: "Pohrebea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 543,
                column: "Name",
                value: "Roghi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 544,
                column: "Name",
                value: "Ustia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 545,
                column: "Name",
                value: "Vasilievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 546,
                column: "Name",
                value: "Comisarovca Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 547,
                column: "Name",
                value: "Crasnîi Vinogradari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 548,
                column: "Name",
                value: "Doibani I");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 549,
                column: "Name",
                value: "Dubăsari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 550,
                column: "Name",
                value: "Dubău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 551,
                column: "Name",
                value: "Dzerjinscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 552,
                column: "Name",
                value: "Goian");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 553,
                column: "Name",
                value: "Harmațca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 554,
                column: "Name",
                value: "Lunga");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 555,
                column: "Name",
                value: "Țîbuleuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Alexăndreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Alexeevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Bădragii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Bădragii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Bleșteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Brătușeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Brătușenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Brînzeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Burlănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Buzdugeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Cepeleuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Chetroșica Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Chetroșica Veche" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Chiurt" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 18, "Clișcăuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 571,
                column: "Name",
                value: "Constantinovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 572,
                column: "Name",
                value: "Corpaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 573,
                column: "Name",
                value: "Cuconeștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 574,
                column: "Name",
                value: "Cuconeștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 575,
                column: "Name",
                value: "Cupcini");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 576,
                column: "Name",
                value: "Edineț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 577,
                column: "Name",
                value: "Fetești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 578,
                column: "Name",
                value: "Fîntîna Albă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 579,
                column: "Name",
                value: "Gașpar");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 580,
                column: "Name",
                value: "Goleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 581,
                column: "Name",
                value: "Gordinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 582,
                column: "Name",
                value: "Gordineștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 583,
                column: "Name",
                value: "Hancăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 584,
                column: "Name",
                value: "Hincăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 585,
                column: "Name",
                value: "Hlinaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 586,
                column: "Name",
                value: "Hlinaia Mică");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 587,
                column: "Name",
                value: "Iachimeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 588,
                column: "Name",
                value: "Lopatnic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 589,
                column: "Name",
                value: "Onești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 590,
                column: "Name",
                value: "Parcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 591,
                column: "Name",
                value: "Poiana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 592,
                column: "Name",
                value: "Rîngaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 593,
                column: "Name",
                value: "Rotunda");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 594,
                column: "Name",
                value: "Ruseni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 595,
                column: "Name",
                value: "Slobodca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 596,
                column: "Name",
                value: "Stolniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 597,
                column: "Name",
                value: "Șofrîncani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 598,
                column: "Name",
                value: "Terebna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 599,
                column: "Name",
                value: "Tîrnova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 600,
                column: "Name",
                value: "Trinca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 601,
                column: "Name",
                value: "Vancicăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 602,
                column: "Name",
                value: "Viișoara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 603,
                column: "Name",
                value: "Volodeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 604,
                column: "Name",
                value: "Zăbriceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Albinețul Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Albinețul Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Beleuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Bocani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Bocșa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Burghelea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Catranîc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Călinești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Călugăr" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Chetriș" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Chetrișul Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ciolacu Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ciolacu Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ciuluc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Comarovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Cuzmenii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Doltu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Drujineni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Egorovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Fălești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Făgădău" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Făleștii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Frumușica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Glinjeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Hiliuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Hitrești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Hîncești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Hîrtop" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Horești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Hrubna Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ilenuța" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ișcălău" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Ivanovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Izvoare" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Logofteni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Lucăceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Măgura" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Măgura Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Măgureanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 19, "Mărăndeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 645,
                column: "Name",
                value: "Moldoveanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 646,
                column: "Name",
                value: "Musteața");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 647,
                column: "Name",
                value: "Natalievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 648,
                column: "Name",
                value: "Năvîrneț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 649,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 650,
                column: "Name",
                value: "Obreja Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 651,
                column: "Name",
                value: "Obreja Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 652,
                column: "Name",
                value: "Pervomaisc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 653,
                column: "Name",
                value: "Pietrosu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 654,
                column: "Name",
                value: "Pietrosul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 655,
                column: "Name",
                value: "Pînzăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 656,
                column: "Name",
                value: "Pînzărenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 657,
                column: "Name",
                value: "Pîrlița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 658,
                column: "Name",
                value: "Pocrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 659,
                column: "Name",
                value: "Pompa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 660,
                column: "Name",
                value: "Popovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 661,
                column: "Name",
                value: "Pruteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 662,
                column: "Name",
                value: "Răuțel");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 663,
                column: "Name",
                value: "Răuțelul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 664,
                column: "Name",
                value: "Rediul de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 665,
                column: "Name",
                value: "Rediul de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 666,
                column: "Name",
                value: "Risipeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 667,
                column: "Name",
                value: "Sărata Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 668,
                column: "Name",
                value: "Sărata Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 669,
                column: "Name",
                value: "Scumpia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 670,
                column: "Name",
                value: "Socii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 671,
                column: "Name",
                value: "Socii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 672,
                column: "Name",
                value: "Suvorovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 673,
                column: "Name",
                value: "Șoltoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 674,
                column: "Name",
                value: "Taxobeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 675,
                column: "Name",
                value: "Țapoc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 676,
                column: "Name",
                value: "Unteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 677,
                column: "Name",
                value: "Valea Rusului");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 678,
                column: "Name",
                value: "Vrănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Alexandrovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Alexeevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Antonovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Băhrinești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Bezeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Bobulești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Bursuc" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Cașunca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Căprești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Cenușa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Cernița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Chirilovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Ciripcău" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Ciutulești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Coșernița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Cuhureștii de Sus" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Cuhureștii de Jos" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Cunicea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Domulgeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Dumitreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Făgădău" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Florești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Frumușica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Frumușica Nouă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Frunzești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Ghindești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Ghindești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Gura Camencii" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Gura Căinarului" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Gvozdova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Hîrtop" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Ion Vodă" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Iliciovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Ivanovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Izvoare" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Japca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Lunga" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 20, "Maiscoe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 717,
                column: "Name",
                value: "Mărinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 718,
                column: "Name",
                value: "Mărculești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 719,
                column: "Name",
                value: "Mărculești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 720,
                column: "Name",
                value: "Mihailovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 721,
                column: "Name",
                value: "Năpadova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 722,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 723,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 724,
                column: "Name",
                value: "Octeabriscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 725,
                column: "Name",
                value: "Prajila");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 726,
                column: "Name",
                value: "Prodănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 727,
                column: "Name",
                value: "Prodăneștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 728,
                column: "Name",
                value: "Putinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 729,
                column: "Name",
                value: "Rădulenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 730,
                column: "Name",
                value: "Rădulenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 731,
                column: "Name",
                value: "Roșietici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 732,
                column: "Name",
                value: "Roșieticii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 733,
                column: "Name",
                value: "Sănătăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 734,
                column: "Name",
                value: "Scăieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 735,
                column: "Name",
                value: "Sevirova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 736,
                column: "Name",
                value: "Sîrbești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 737,
                column: "Name",
                value: "Stîrceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 738,
                column: "Name",
                value: "Ștefănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 739,
                column: "Name",
                value: "Temeleuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 740,
                column: "Name",
                value: "Tîrgul Vertiujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 741,
                column: "Name",
                value: "Trifănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 742,
                column: "Name",
                value: "Țipordei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 743,
                column: "Name",
                value: "Țîra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 744,
                column: "Name",
                value: "Unchitești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 745,
                column: "Name",
                value: "Valea Rădoaiei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 746,
                column: "Name",
                value: "Vărvăreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 747,
                column: "Name",
                value: "Văscăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 748,
                column: "Name",
                value: "Vertiujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 749,
                column: "Name",
                value: "Zarojeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 750,
                column: "Name",
                value: "Zăluceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 21, "Balatina" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 752,
                column: "Name",
                value: "Bisericani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 753,
                column: "Name",
                value: "Brînzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 754,
                column: "Name",
                value: "Butești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 755,
                column: "Name",
                value: "Cajba");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 756,
                column: "Name",
                value: "Camenca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 757,
                column: "Name",
                value: "Camencuța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 758,
                column: "Name",
                value: "Ciuciulea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 759,
                column: "Name",
                value: "Clococenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 760,
                column: "Name",
                value: "Cobani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 761,
                column: "Name",
                value: "Cot");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 762,
                column: "Name",
                value: "Cuhnești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 763,
                column: "Name",
                value: "Danu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 764,
                column: "Name",
                value: "Dușmani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 765,
                column: "Name",
                value: "Fundurii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 766,
                column: "Name",
                value: "Fundurii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 767,
                column: "Name",
                value: "Glodeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 768,
                column: "Name",
                value: "Hîjdieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 769,
                column: "Name",
                value: "Iabloana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 770,
                column: "Name",
                value: "Limbenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 771,
                column: "Name",
                value: "Limbenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 772,
                column: "Name",
                value: "Lipovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 773,
                column: "Name",
                value: "Moara Domnească");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 774,
                column: "Name",
                value: "Molești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 775,
                column: "Name",
                value: "Movileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 776,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 777,
                column: "Name",
                value: "Petrunea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 778,
                column: "Name",
                value: "Serghieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 779,
                column: "Name",
                value: "Soroca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 780,
                column: "Name",
                value: "Stîrcea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 781,
                column: "Name",
                value: "Sturzovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 782,
                column: "Name",
                value: "Tomeștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 783,
                column: "Name",
                value: "Tomeștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 784,
                column: "Name",
                value: "Ustia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 785,
                column: "Name",
                value: "Viișoara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Anini" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Bălceana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Bobeica" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Boghiceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Bozieni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Brătianovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Bujor" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Buțeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Caracui" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Călmățui" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Cărpineni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Cărpineanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Cățeleni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Chetroșeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Cioara" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Ciuciuleni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Cornești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Coroliovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Costești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Cotul Morii" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Crasnoarmeiscoe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Dahnovici" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Dancu" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Drăgușeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Drăgușenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Dubovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Feteasca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Fîrlădeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 22, "Frasin" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 815,
                column: "Name",
                value: "Fundul Galbenei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 816,
                column: "Name",
                value: "Hîncești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 817,
                column: "Name",
                value: "Horjești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 818,
                column: "Name",
                value: "Horodca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 819,
                column: "Name",
                value: "Ivanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 820,
                column: "Name",
                value: "Lăpușna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 821,
                column: "Name",
                value: "Leușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 822,
                column: "Name",
                value: "Logănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 823,
                column: "Name",
                value: "Marchet");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 824,
                column: "Name",
                value: "Mereșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 825,
                column: "Name",
                value: "Mingir");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 826,
                column: "Name",
                value: "Mirești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 827,
                column: "Name",
                value: "Negrea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 828,
                column: "Name",
                value: "Nemțeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 829,
                column: "Name",
                value: "Obileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 830,
                column: "Name",
                value: "Onești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 831,
                column: "Name",
                value: "Pașcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 832,
                column: "Name",
                value: "Pereni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 833,
                column: "Name",
                value: "Pervomaiscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 834,
                column: "Name",
                value: "Pogănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 835,
                column: "Name",
                value: "Rusca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 836,
                column: "Name",
                value: "Sărata-Galbenă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 837,
                column: "Name",
                value: "Sărata-Mereșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 838,
                column: "Name",
                value: "Sărăteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 839,
                column: "Name",
                value: "Secăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 840,
                column: "Name",
                value: "Secărenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 841,
                column: "Name",
                value: "Semionovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 842,
                column: "Name",
                value: "Sofia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 843,
                column: "Name",
                value: "Stolniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 844,
                column: "Name",
                value: "Strîmbeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 845,
                column: "Name",
                value: "Șipoteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 846,
                column: "Name",
                value: "Tălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 847,
                column: "Name",
                value: "Valea Florii");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 848,
                column: "Name",
                value: "Voinescu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 849,
                column: "Name",
                value: "Alexandrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 850,
                column: "Name",
                value: "Bardar");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 851,
                column: "Name",
                value: "Bălțați");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 852,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 853,
                column: "Name",
                value: "Cărbuna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 854,
                column: "Name",
                value: "Cigîrleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 855,
                column: "Name",
                value: "Costești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 856,
                column: "Name",
                value: "Dănceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 857,
                column: "Name",
                value: "Gangura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 858,
                column: "Name",
                value: "Găureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 859,
                column: "Name",
                value: "Hansca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 860,
                column: "Name",
                value: "Horești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 861,
                column: "Name",
                value: "Homuteanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 862,
                column: "Name",
                value: "Horodca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 863,
                column: "Name",
                value: "Ialoveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 864,
                column: "Name",
                value: "Malcoci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 865,
                column: "Name",
                value: "Mileștii Mici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 866,
                column: "Name",
                value: "Mileștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 867,
                column: "Name",
                value: "Misovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 868,
                column: "Name",
                value: "Molești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 869,
                column: "Name",
                value: "Nimoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 870,
                column: "Name",
                value: "Piatra Albă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 871,
                column: "Name",
                value: "Pojăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 872,
                column: "Name",
                value: "Puhoi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 873,
                column: "Name",
                value: "Răzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 874,
                column: "Name",
                value: "Ruseștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 875,
                column: "Name",
                value: "Ruseștii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 876,
                column: "Name",
                value: "Sociteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 877,
                column: "Name",
                value: "Suruceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 878,
                column: "Name",
                value: "Țipala");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 879,
                column: "Name",
                value: "Ulmu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 880,
                column: "Name",
                value: "Văratic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 881,
                column: "Name",
                value: "Văsieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 882,
                column: "Name",
                value: "Zîmbreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Băcșeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Bălănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Bălăurești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Bărboieni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Boldurești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 24, "Bolțun" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 889,
                column: "Name",
                value: "Brătuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 890,
                column: "Name",
                value: "Bursuc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 891,
                column: "Name",
                value: "Călimănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 892,
                column: "Name",
                value: "Chilișoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 893,
                column: "Name",
                value: "Ciorești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 894,
                column: "Name",
                value: "Ciutești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 895,
                column: "Name",
                value: "Cîrnești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 896,
                column: "Name",
                value: "Cristești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 897,
                column: "Name",
                value: "Drojdieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 898,
                column: "Name",
                value: "Găureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 899,
                column: "Name",
                value: "Grozești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 900,
                column: "Name",
                value: "Heleșteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 901,
                column: "Name",
                value: "Isăicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 902,
                column: "Name",
                value: "Iurceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 903,
                column: "Name",
                value: "Luminița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 904,
                column: "Name",
                value: "Marinici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 905,
                column: "Name",
                value: "Milești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 906,
                column: "Name",
                value: "Mîrzoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 907,
                column: "Name",
                value: "Nisporeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 908,
                column: "Name",
                value: "Odaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 909,
                column: "Name",
                value: "Odobești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 910,
                column: "Name",
                value: "Păruceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 911,
                column: "Name",
                value: "Seliște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 912,
                column: "Name",
                value: "Selișteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 913,
                column: "Name",
                value: "Soltănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 914,
                column: "Name",
                value: "Șendreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 915,
                column: "Name",
                value: "Șișcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 916,
                column: "Name",
                value: "Valea Nîrnovei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 917,
                column: "Name",
                value: "Valea-Trestieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 918,
                column: "Name",
                value: "Vărzărești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 920,
                column: "Name",
                value: "Vulcănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 921,
                column: "Name",
                value: "Zberoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Berezovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Bîrlădeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Bîrnova" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Călărașeuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Clocușna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 25, "Codreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 928,
                column: "Name",
                value: "Corestăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 929,
                column: "Name",
                value: "Dîngeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 930,
                column: "Name",
                value: "Frunză");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 931,
                column: "Name",
                value: "Gîrbova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 932,
                column: "Name",
                value: "Grinăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 933,
                column: "Name",
                value: "Grinăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 934,
                column: "Name",
                value: "Grinăuți-Moldova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 935,
                column: "Name",
                value: "Grinăuți-Raia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 936,
                column: "Name",
                value: "Hădărăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 937,
                column: "Name",
                value: "Lencăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 938,
                column: "Name",
                value: "Lipnic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 939,
                column: "Name",
                value: "Maiovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 940,
                column: "Name",
                value: "Mereșeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 941,
                column: "Name",
                value: "Mihălășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 942,
                column: "Name",
                value: "Naslavcea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 943,
                column: "Name",
                value: "Ocnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 944,
                column: "Name",
                value: "Ocnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 945,
                column: "Name",
                value: "Otaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 946,
                column: "Name",
                value: "Paladea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 947,
                column: "Name",
                value: "Paustova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 948,
                column: "Name",
                value: "Rediul Mare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 949,
                column: "Name",
                value: "Rujnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 950,
                column: "Name",
                value: "Sauca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 951,
                column: "Name",
                value: "Stălinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 952,
                column: "Name",
                value: "Unguri");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 953,
                column: "Name",
                value: "Vălcineț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 954,
                column: "Name",
                value: "Verejeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Andreevca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Berezlogi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Biești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Bolohan" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Brănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 26, "Brăviceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 961,
                column: "Name",
                value: "Breanova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 962,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 963,
                column: "Name",
                value: "Bulăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 964,
                column: "Name",
                value: "Butuceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 965,
                column: "Name",
                value: "Camencea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 966,
                column: "Name",
                value: "Chiperceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 967,
                column: "Name",
                value: "Cihoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 968,
                column: "Name",
                value: "Ciocîlteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 969,
                column: "Name",
                value: "Cișmea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 970,
                column: "Name",
                value: "Clișova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 971,
                column: "Name",
                value: "Clișova Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 972,
                column: "Name",
                value: "Crihana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 973,
                column: "Name",
                value: "Cucuruzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 974,
                column: "Name",
                value: "Cucuruzenii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 975,
                column: "Name",
                value: "Curchi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 976,
                column: "Name",
                value: "Dișcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 977,
                column: "Name",
                value: "Donici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 978,
                column: "Name",
                value: "Fedoreuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 979,
                column: "Name",
                value: "Furceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 980,
                column: "Name",
                value: "Ghetlova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 981,
                column: "Name",
                value: "Hîjdieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 982,
                column: "Name",
                value: "Hulboaca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 983,
                column: "Name",
                value: "Inculeț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 984,
                column: "Name",
                value: "Isacova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 985,
                column: "Name",
                value: "Ivancea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 986,
                column: "Name",
                value: "Izvoare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 987,
                column: "Name",
                value: "Jeloboc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 988,
                column: "Name",
                value: "Jora de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 989,
                column: "Name",
                value: "Jora de Mijloc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 990,
                column: "Name",
                value: "Jora de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 991,
                column: "Name",
                value: "Jeloboc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 992,
                column: "Name",
                value: "Lopatna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 993,
                column: "Name",
                value: "Lucășeuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 994,
                column: "Name",
                value: "Mana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 995,
                column: "Name",
                value: "Mălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 996,
                column: "Name",
                value: "Mitoc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 997,
                column: "Name",
                value: "Mîrzaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 998,
                column: "Name",
                value: "Mîrzești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 999,
                column: "Name",
                value: "Morovaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Name",
                value: "Morozeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1001,
                column: "Name",
                value: "Neculăieuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1002,
                column: "Name",
                value: "Noroceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1003,
                column: "Name",
                value: "Ocnița-Răzeși");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1004,
                column: "Name",
                value: "Ocnița-Țărani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1005,
                column: "Name",
                value: "Orhei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1006,
                column: "Name",
                value: "Pelivan");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1007,
                column: "Name",
                value: "Peresecina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1008,
                column: "Name",
                value: "Piatra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1009,
                column: "Name",
                value: "Pocșești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1010,
                column: "Name",
                value: "Podgoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1011,
                column: "Name",
                value: "Pohorniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1012,
                column: "Name",
                value: "Pohrebeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1013,
                column: "Name",
                value: "Puțintei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1014,
                column: "Name",
                value: "Sămănanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1015,
                column: "Name",
                value: "Seliște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1016,
                column: "Name",
                value: "Sirota");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1017,
                column: "Name",
                value: "Slobozia-Hodorogea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1018,
                column: "Name",
                value: "Step-Soci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1019,
                column: "Name",
                value: "Susleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1020,
                column: "Name",
                value: "Șercani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1021,
                column: "Name",
                value: "Tabăra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1022,
                column: "Name",
                value: "Teleșeu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1023,
                column: "Name",
                value: "Tîrzieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1024,
                column: "Name",
                value: "Trebujeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1025,
                column: "Name",
                value: "Vatici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1026,
                column: "Name",
                value: "Vîprova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1027,
                column: "Name",
                value: "Vîșcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1028,
                column: "Name",
                value: "Voroteț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1029,
                column: "Name",
                value: "Zahoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1030,
                column: "Name",
                value: "Zorile");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Boșernița" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Buciușca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Bușăuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Cinișeuți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Ciorna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 27, "Cogîlniceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1037,
                column: "Name",
                value: "Cuizăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1038,
                column: "Name",
                value: "Echimăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1039,
                column: "Name",
                value: "Ghiduleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1040,
                column: "Name",
                value: "Gordinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1041,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1042,
                column: "Name",
                value: "Ignăței");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1043,
                column: "Name",
                value: "Lalova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1044,
                column: "Name",
                value: "Lipceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1045,
                column: "Name",
                value: "Mateuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1046,
                column: "Name",
                value: "Meșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1047,
                column: "Name",
                value: "Mincenii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1048,
                column: "Name",
                value: "Mincenii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1049,
                column: "Name",
                value: "Nistreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1050,
                column: "Name",
                value: "Otac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1051,
                column: "Name",
                value: "Păpăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1052,
                column: "Name",
                value: "Peciște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1053,
                column: "Name",
                value: "Pereni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1054,
                column: "Name",
                value: "Piscărești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1055,
                column: "Name",
                value: "Pripiceni-Curchi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1056,
                column: "Name",
                value: "Pripiceni-Răzeși");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1057,
                column: "Name",
                value: "Rezina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1058,
                column: "Name",
                value: "Roșcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1059,
                column: "Name",
                value: "Roșcanii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1060,
                column: "Name",
                value: "Roșcanii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1061,
                column: "Name",
                value: "Saharna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1062,
                column: "Name",
                value: "Saharna Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1063,
                column: "Name",
                value: "Sîrcova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1064,
                column: "Name",
                value: "Slobozia-Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1065,
                column: "Name",
                value: "Solonceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1066,
                column: "Name",
                value: "Stohnaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1067,
                column: "Name",
                value: "Tarasova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1068,
                column: "Name",
                value: "Trifești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1069,
                column: "Name",
                value: "Țahnăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1070,
                column: "Name",
                value: "Țareuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1071,
                column: "Name",
                value: "Țipova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Alexăndrești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Aluniș" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Armanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Avrămeni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Bălanu Nou" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 28, "Borosenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1078,
                column: "Name",
                value: "Braniște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1079,
                column: "Name",
                value: "Bulhac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1080,
                column: "Name",
                value: "Cepăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1081,
                column: "Name",
                value: "Ciobanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1082,
                column: "Name",
                value: "Corlăteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1083,
                column: "Name",
                value: "Costești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1084,
                column: "Name",
                value: "Cucuieții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1085,
                column: "Name",
                value: "Cucuieții Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1086,
                column: "Name",
                value: "Dămășcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1087,
                column: "Name",
                value: "Druța");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1088,
                column: "Name",
                value: "Dumeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1089,
                column: "Name",
                value: "Duruitoarea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1090,
                column: "Name",
                value: "Duruitoarea Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1091,
                column: "Name",
                value: "Gălășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1092,
                column: "Name",
                value: "Grinăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1093,
                column: "Name",
                value: "Hiliuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1094,
                column: "Name",
                value: "Horodiște");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1095,
                column: "Name",
                value: "Ivănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Name",
                value: "Lupăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1097,
                column: "Name",
                value: "Malinovscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1098,
                column: "Name",
                value: "Mălăiești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1099,
                column: "Name",
                value: "Mihăileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1100,
                column: "Name",
                value: "Mihăilenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1101,
                column: "Name",
                value: "Moșeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1102,
                column: "Name",
                value: "Nihoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1103,
                column: "Name",
                value: "Păscăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1104,
                column: "Name",
                value: "Petrușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1105,
                column: "Name",
                value: "Pîrjota");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1106,
                column: "Name",
                value: "Pociumbăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1107,
                column: "Name",
                value: "Pociumbeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1108,
                column: "Name",
                value: "Proscureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1109,
                column: "Name",
                value: "Răcăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1110,
                column: "Name",
                value: "Rămăzan");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1111,
                column: "Name",
                value: "Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1112,
                column: "Name",
                value: "Reteni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1113,
                column: "Name",
                value: "Reteni-Vasileuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1114,
                column: "Name",
                value: "Rîșcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1115,
                column: "Name",
                value: "Singureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1116,
                column: "Name",
                value: "Slobozia-Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1117,
                column: "Name",
                value: "Sturzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1118,
                column: "Name",
                value: "Sverdiac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1119,
                column: "Name",
                value: "Șaptebani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1120,
                column: "Name",
                value: "Știubeieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1121,
                column: "Name",
                value: "Șumna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Name",
                value: "Ușurei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1123,
                column: "Name",
                value: "Vasileuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1124,
                column: "Name",
                value: "Văratic");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1125,
                column: "Name",
                value: "Zăicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Alexăndreni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Alexeuca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Antonovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Bălășești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Bilicenii Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 29, "Bilicenii Vechi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1132,
                column: "Name",
                value: "Biruința");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1133,
                column: "Name",
                value: "Bobletici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1134,
                column: "Name",
                value: "Bocancea-Schit");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1135,
                column: "Name",
                value: "Brejeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1136,
                column: "Name",
                value: "Bursuceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1137,
                column: "Name",
                value: "Chirileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1138,
                column: "Name",
                value: "Chișcăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1139,
                column: "Name",
                value: "Ciuciuieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1140,
                column: "Name",
                value: "Clișcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1141,
                column: "Name",
                value: "Coada Iazului");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1142,
                column: "Name",
                value: "Copăceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1143,
                column: "Name",
                value: "Coșcodeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1144,
                column: "Name",
                value: "Cotiujenii Mici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1145,
                column: "Name",
                value: "Cotovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1146,
                column: "Name",
                value: "Cozești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1147,
                column: "Name",
                value: "Cubolta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1148,
                column: "Name",
                value: "Dobrogea Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1149,
                column: "Name",
                value: "Dobrogea Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1150,
                column: "Name",
                value: "Drăgănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1151,
                column: "Name",
                value: "Dumbrăvița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1152,
                column: "Name",
                value: "Evghenievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1153,
                column: "Name",
                value: "Flămînzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1154,
                column: "Name",
                value: "Gavrilovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1155,
                column: "Name",
                value: "Grigorăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1156,
                column: "Name",
                value: "Grigorești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1157,
                column: "Name",
                value: "Gura-Oituz");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1158,
                column: "Name",
                value: "Heciul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1159,
                column: "Name",
                value: "Heciul Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1160,
                column: "Name",
                value: "Iezărenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1161,
                column: "Name",
                value: "Iezărenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1162,
                column: "Name",
                value: "Izvoare");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1163,
                column: "Name",
                value: "Lipovanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1164,
                column: "Name",
                value: "Mărășești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1165,
                column: "Name",
                value: "Mărinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1166,
                column: "Name",
                value: "Mihailovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1167,
                column: "Name",
                value: "Mîndreștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1168,
                column: "Name",
                value: "Nicolaevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1169,
                column: "Name",
                value: "Octeabriscoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1170,
                column: "Name",
                value: "Pălăria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1171,
                column: "Name",
                value: "Pepeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1172,
                column: "Name",
                value: "Pepenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1173,
                column: "Name",
                value: "Petrovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1174,
                column: "Name",
                value: "Petropavlovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1175,
                column: "Name",
                value: "Prepelița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1176,
                column: "Name",
                value: "Rădoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1177,
                column: "Name",
                value: "Răzălăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1178,
                column: "Name",
                value: "Romanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1179,
                column: "Name",
                value: "Sacarovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1180,
                column: "Name",
                value: "Sîngerei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1181,
                column: "Name",
                value: "Sîngereii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1182,
                column: "Name",
                value: "Slobozia-Chișcăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1183,
                column: "Name",
                value: "Slobozia-Măgura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1184,
                column: "Name",
                value: "Sloveanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1185,
                column: "Name",
                value: "Șestaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1186,
                column: "Name",
                value: "Tăura Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1187,
                column: "Name",
                value: "Tăura Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1188,
                column: "Name",
                value: "Trifănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1189,
                column: "Name",
                value: "Țambula");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1190,
                column: "Name",
                value: "Țiplești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1191,
                column: "Name",
                value: "Țipletești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1192,
                column: "Name",
                value: "Valea lui Vlad");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1193,
                column: "Name",
                value: "Valea Norocului");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1194,
                column: "Name",
                value: "Vladimireuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1195,
                column: "Name",
                value: "Vrănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Alexandru cel Bun" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Balinți" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Balinții Noi" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Bădiceni" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Băxani" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 30, "Bulboci" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1202,
                column: "Name",
                value: "Bulbocii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1203,
                column: "Name",
                value: "Căinarii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1204,
                column: "Name",
                value: "Cerlina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1205,
                column: "Name",
                value: "Cosăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1206,
                column: "Name",
                value: "Cremenciug");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1207,
                column: "Name",
                value: "Cureșnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1208,
                column: "Name",
                value: "Cureșnița Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1209,
                column: "Name",
                value: "Dărcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1210,
                column: "Name",
                value: "Dărcăuții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1211,
                column: "Name",
                value: "Decebal");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1212,
                column: "Name",
                value: "Dubna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1213,
                column: "Name",
                value: "Dumbrăveni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1214,
                column: "Name",
                value: "Egoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1215,
                column: "Name",
                value: "Floriceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1216,
                column: "Name",
                value: "Grigorăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1217,
                column: "Name",
                value: "Holoșnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1218,
                column: "Name",
                value: "Hristici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1219,
                column: "Name",
                value: "Iarova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1220,
                column: "Name",
                value: "Iorjnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1221,
                column: "Name",
                value: "Inundeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1222,
                column: "Name",
                value: "Livezi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1223,
                column: "Name",
                value: "Lugovoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1224,
                column: "Name",
                value: "Mălcăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1225,
                column: "Name",
                value: "Nimereuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1226,
                column: "Name",
                value: "Niorcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1227,
                column: "Name",
                value: "Oclanda");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1228,
                column: "Name",
                value: "Ocolina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1229,
                column: "Name",
                value: "Parcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1230,
                column: "Name",
                value: "Pîrlița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1231,
                column: "Name",
                value: "Racovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1232,
                column: "Name",
                value: "Redi-Cereșnovăț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1233,
                column: "Name",
                value: "Regina Maria");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1234,
                column: "Name",
                value: "Rublenița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1235,
                column: "Name",
                value: "Rublenița Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1236,
                column: "Name",
                value: "Ruslanovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1237,
                column: "Name",
                value: "Rudi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1238,
                column: "Name",
                value: "Schineni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1239,
                column: "Name",
                value: "Schinenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1240,
                column: "Name",
                value: "Slobozia-Cremene");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1241,
                column: "Name",
                value: "Slobozia Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1242,
                column: "Name",
                value: "Slobozia-Vărăncău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1243,
                column: "Name",
                value: "Sobari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1244,
                column: "Name",
                value: "Soloneț");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1245,
                column: "Name",
                value: "Soroca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1246,
                column: "Name",
                value: "Stoicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1247,
                column: "Name",
                value: "Șeptelici");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1248,
                column: "Name",
                value: "Șolcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1249,
                column: "Name",
                value: "Tătărăuca Veche");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1250,
                column: "Name",
                value: "Tolocănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1251,
                column: "Name",
                value: "Trifăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1252,
                column: "Name",
                value: "Țepilova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1253,
                column: "Name",
                value: "Valea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1254,
                column: "Name",
                value: "Vanțina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1255,
                column: "Name",
                value: "Vanțina Mică");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1256,
                column: "Name",
                value: "Vasilcău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1257,
                column: "Name",
                value: "Vărăncău");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1258,
                column: "Name",
                value: "Vădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1259,
                column: "Name",
                value: "Visoca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1260,
                column: "Name",
                value: "Voloave");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1261,
                column: "Name",
                value: "Volovița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1262,
                column: "Name",
                value: "Zastînca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Bucovăț" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1264,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Căpriana" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1265,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Chirianca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1266,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Ciobanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1267,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Codreanca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1268,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 31, "Cojușna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1269,
                column: "Name",
                value: "Dolna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1270,
                column: "Name",
                value: "Drăgușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1271,
                column: "Name",
                value: "Făgureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1272,
                column: "Name",
                value: "Gălești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1273,
                column: "Name",
                value: "Găleștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1274,
                column: "Name",
                value: "Ghelăuza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1275,
                column: "Name",
                value: "Gornoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1276,
                column: "Name",
                value: "Greblești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1277,
                column: "Name",
                value: "Huzun");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1278,
                column: "Name",
                value: "Lozova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1279,
                column: "Name",
                value: "Lupa-Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1280,
                column: "Name",
                value: "Mărtinești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1281,
                column: "Name",
                value: "Micăuți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1282,
                column: "Name",
                value: "Micleușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1283,
                column: "Name",
                value: "Negrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1284,
                column: "Name",
                value: "Onești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1285,
                column: "Name",
                value: "Pănășești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1286,
                column: "Name",
                value: "Rassvet");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1287,
                column: "Name",
                value: "Rădeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1288,
                column: "Name",
                value: "Recea");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1289,
                column: "Name",
                value: "Romănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1290,
                column: "Name",
                value: "Roșcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1291,
                column: "Name",
                value: "Saca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1292,
                column: "Name",
                value: "Scoreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1293,
                column: "Name",
                value: "Sireți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1294,
                column: "Name",
                value: "Stejăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1295,
                column: "Name",
                value: "Strășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1296,
                column: "Name",
                value: "Tătărești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1297,
                column: "Name",
                value: "Țigănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1298,
                column: "Name",
                value: "Voinova");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1299,
                column: "Name",
                value: "Vorniceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Name",
                value: "Zamciogi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1301,
                column: "Name",
                value: "Zubrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1302,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Alcedar" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Chipeșca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Climăuții de Jos" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Cobîlea" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Cot" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 32, "Cotiujenii Mari" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1308,
                column: "Name",
                value: "Curătura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1309,
                column: "Name",
                value: "Cușelăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1310,
                column: "Name",
                value: "Cușmirca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1311,
                column: "Name",
                value: "Dobrușa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1312,
                column: "Name",
                value: "Fuzăuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1313,
                column: "Name",
                value: "Găuzeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1314,
                column: "Name",
                value: "Glinjeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1315,
                column: "Name",
                value: "Lelina");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1316,
                column: "Name",
                value: "Mihuleni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1317,
                column: "Name",
                value: "Odaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1318,
                column: "Name",
                value: "Olișcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1319,
                column: "Name",
                value: "Parcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1320,
                column: "Name",
                value: "Pohoarna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1321,
                column: "Name",
                value: "Poiana");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1322,
                column: "Name",
                value: "Răspopeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1323,
                column: "Name",
                value: "Recești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1324,
                column: "Name",
                value: "Rogojeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1325,
                column: "Name",
                value: "Salcia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1326,
                column: "Name",
                value: "Sămășcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1327,
                column: "Name",
                value: "Socola");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1328,
                column: "Name",
                value: "Șestaci");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1329,
                column: "Name",
                value: "Șipca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1330,
                column: "Name",
                value: "Șoldănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1331,
                column: "Name",
                value: "Vadul-Rașcov");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1332,
                column: "Name",
                value: "Zahorna");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1333,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 33, "Alava" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1334,
                column: "Name",
                value: "Antonești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1335,
                column: "Name",
                value: "Brezoaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1336,
                column: "Name",
                value: "Carahasani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1337,
                column: "Name",
                value: "Căplani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1338,
                column: "Name",
                value: "Cioburciu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1339,
                column: "Name",
                value: "Copceac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1340,
                column: "Name",
                value: "Crocmaz");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1341,
                column: "Name",
                value: "Ermoclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1342,
                column: "Name",
                value: "Feștelița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1343,
                column: "Name",
                value: "Lazo");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1344,
                column: "Name",
                value: "Marianca de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1345,
                column: "Name",
                value: "Olănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1346,
                column: "Name",
                value: "Palanca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1347,
                column: "Name",
                value: "Popeasca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1348,
                column: "Name",
                value: "Purcari");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1349,
                column: "Name",
                value: "Răscăieți");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1350,
                column: "Name",
                value: "Răscăieții Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1351,
                column: "Name",
                value: "Semionovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1352,
                column: "Name",
                value: "Slobozia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1353,
                column: "Name",
                value: "Ștefan Vodă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1354,
                column: "Name",
                value: "Ștefănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1355,
                column: "Name",
                value: "Talmaza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1356,
                column: "Name",
                value: "Tudora");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1357,
                column: "Name",
                value: "Viișoara");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1358,
                column: "Name",
                value: "Volintiri");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 34, "Albota de Jos" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1360,
                column: "Name",
                value: "Albota de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1361,
                column: "Name",
                value: "Aluatu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1362,
                column: "Name",
                value: "Balabanu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1363,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1364,
                column: "Name",
                value: "Cairaclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1365,
                column: "Name",
                value: "Cealîc");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1366,
                column: "Name",
                value: "Ciumai");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1367,
                column: "Name",
                value: "Chirilovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1368,
                column: "Name",
                value: "Corten");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1369,
                column: "Name",
                value: "Cortenul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1370,
                column: "Name",
                value: "Dermengi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1371,
                column: "Name",
                value: "Hagichioi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1372,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1373,
                column: "Name",
                value: "Mirnoe");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1374,
                column: "Name",
                value: "Musaitu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1375,
                column: "Name",
                value: "Novosiolovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1376,
                column: "Name",
                value: "Orehovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1377,
                column: "Name",
                value: "Roșița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1378,
                column: "Name",
                value: "Salcia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1379,
                column: "Name",
                value: "Samurza");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1380,
                column: "Name",
                value: "Sofievca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1381,
                column: "Name",
                value: "Taraclia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1382,
                column: "Name",
                value: "Tvardița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1383,
                column: "Name",
                value: "Valea Perjei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1384,
                column: "Name",
                value: "Vinogradovca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 35, "Bănești" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1386,
                column: "Name",
                value: "Băneștii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1387,
                column: "Name",
                value: "Bogzești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1388,
                column: "Name",
                value: "Bondareuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1389,
                column: "Name",
                value: "Brînzenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1390,
                column: "Name",
                value: "Brînzenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1391,
                column: "Name",
                value: "Budăi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1392,
                column: "Name",
                value: "Căzănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1393,
                column: "Name",
                value: "Chersac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1394,
                column: "Name",
                value: "Chiștelnița");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1395,
                column: "Name",
                value: "Chițcanii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1396,
                column: "Name",
                value: "Chițcanii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1397,
                column: "Name",
                value: "Ciofu");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1398,
                column: "Name",
                value: "Ciulucani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1399,
                column: "Name",
                value: "Cîșla");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1400,
                column: "Name",
                value: "Codru");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1401,
                column: "Name",
                value: "Codrul Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1402,
                column: "Name",
                value: "Coropceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1403,
                column: "Name",
                value: "Crăsnășeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1404,
                column: "Name",
                value: "Cucioaia");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1405,
                column: "Name",
                value: "Cucioaia Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1406,
                column: "Name",
                value: "Dobrușa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1407,
                column: "Name",
                value: "Flutura");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1408,
                column: "Name",
                value: "Ghermănești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1409,
                column: "Name",
                value: "Ghiliceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1410,
                column: "Name",
                value: "Hirișeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1411,
                column: "Name",
                value: "Hîrtop");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1412,
                column: "Name",
                value: "Inești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1413,
                column: "Name",
                value: "Leușeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1414,
                column: "Name",
                value: "Mihălașa");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1415,
                column: "Name",
                value: "Mihălașa Nouă");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1416,
                column: "Name",
                value: "Mîndra");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1417,
                column: "Name",
                value: "Mîndrești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1418,
                column: "Name",
                value: "Negureni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1419,
                column: "Name",
                value: "Nucăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1420,
                column: "Name",
                value: "Ordășei");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1421,
                column: "Name",
                value: "Pistruieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1422,
                column: "Name",
                value: "Pistruienii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1423,
                column: "Name",
                value: "Ratuș");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1424,
                column: "Name",
                value: "Sărătenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1425,
                column: "Name",
                value: "Sărătenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1426,
                column: "Name",
                value: "Scorțeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1427,
                column: "Name",
                value: "Suhuluceni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1428,
                column: "Name",
                value: "Telenești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1429,
                column: "Name",
                value: "Tîrșiței");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1430,
                column: "Name",
                value: "Țînțăreni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1431,
                column: "Name",
                value: "Vadul-Leca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1432,
                column: "Name",
                value: "Vadul-Leca Nou");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1433,
                column: "Name",
                value: "Văsieni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1434,
                column: "Name",
                value: "Verejeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1435,
                column: "Name",
                value: "Zahareuca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1436,
                column: "Name",
                value: "Zăicani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1437,
                column: "Name",
                value: "Zăicanii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1438,
                column: "Name",
                value: "Zgărdești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "DistrictId", "Name" },
                values: new object[] { 36, "Agronomovca" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1440,
                column: "Name",
                value: "Alexeevca");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1441,
                column: "Name",
                value: "Blindești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1442,
                column: "Name",
                value: "Boghenii Noi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1443,
                column: "Name",
                value: "Boghenii Vechi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1444,
                column: "Name",
                value: "Buciumeni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1445,
                column: "Name",
                value: "Bulhac");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1446,
                column: "Name",
                value: "Bumbăta");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1447,
                column: "Name",
                value: "Bușila");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1448,
                column: "Name",
                value: "Buzduganii de Jos");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1449,
                column: "Name",
                value: "Buzduganii de Sus");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1450,
                column: "Name",
                value: "Cetireni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1451,
                column: "Name",
                value: "Chirileni");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1452,
                column: "Name",
                value: "Cioropcani");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1453,
                column: "Name",
                value: "Condrătești");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1454,
                column: "Name",
                value: "Cornești");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 919, 24, "Vînători" });
        }
    }
}
