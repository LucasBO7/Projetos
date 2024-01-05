using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.banco.digital.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDomainsToEnglishLanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Usuarios_IdUsuarioDestinatario",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Usuarios_IdUsuarioRemetente",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Contas_IdConta",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuario_IdTipoUsuario",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "NomeCompleto",
                table: "Usuarios",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "IdTipoUsuario",
                table: "Usuarios",
                newName: "IdUserType");

            migrationBuilder.RenameColumn(
                name: "IdConta",
                table: "Usuarios",
                newName: "IdAccount");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdTipoUsuario",
                table: "Usuarios",
                newName: "IX_Usuarios_IdUserType");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdConta",
                table: "Usuarios",
                newName: "IX_Usuarios_IdAccount");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Transferencias",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioRemetente",
                table: "Transferencias",
                newName: "IdSenderUser");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioDestinatario",
                table: "Transferencias",
                newName: "IdRecipientUser");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Transferencias",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "IdTransferencia",
                table: "Transferencias",
                newName: "IdTransfer");

            migrationBuilder.RenameIndex(
                name: "IX_Transferencias_IdUsuarioRemetente",
                table: "Transferencias",
                newName: "IX_Transferencias_IdSenderUser");

            migrationBuilder.RenameIndex(
                name: "IX_Transferencias_IdUsuarioDestinatario",
                table: "Transferencias",
                newName: "IX_Transferencias_IdRecipientUser");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "TiposUsuario",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "Contas",
                newName: "Balance");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Contas",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "IdConta",
                table: "Contas",
                newName: "IdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CpfOrCnpj",
                table: "Usuarios",
                column: "CpfOrCnpj",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TiposUsuario_Name",
                table: "TiposUsuario",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contas_Number",
                table: "Contas",
                column: "Number",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Usuarios_IdRecipientUser",
                table: "Transferencias",
                column: "IdRecipientUser",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Usuarios_IdSenderUser",
                table: "Transferencias",
                column: "IdSenderUser",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Contas_IdAccount",
                table: "Usuarios",
                column: "IdAccount",
                principalTable: "Contas",
                principalColumn: "IdAccount",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuario_IdUserType",
                table: "Usuarios",
                column: "IdUserType",
                principalTable: "TiposUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Usuarios_IdRecipientUser",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Transferencias_Usuarios_IdSenderUser",
                table: "Transferencias");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Contas_IdAccount",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_TiposUsuario_IdUserType",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_CpfOrCnpj",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Email",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_TiposUsuario_Name",
                table: "TiposUsuario");

            migrationBuilder.DropIndex(
                name: "IX_Contas_Number",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "IdUserType",
                table: "Usuarios",
                newName: "IdTipoUsuario");

            migrationBuilder.RenameColumn(
                name: "IdAccount",
                table: "Usuarios",
                newName: "IdConta");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Usuarios",
                newName: "NomeCompleto");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdUserType",
                table: "Usuarios",
                newName: "IX_Usuarios_IdTipoUsuario");

            migrationBuilder.RenameIndex(
                name: "IX_Usuarios_IdAccount",
                table: "Usuarios",
                newName: "IX_Usuarios_IdConta");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Transferencias",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "IdSenderUser",
                table: "Transferencias",
                newName: "IdUsuarioRemetente");

            migrationBuilder.RenameColumn(
                name: "IdRecipientUser",
                table: "Transferencias",
                newName: "IdUsuarioDestinatario");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Transferencias",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "IdTransfer",
                table: "Transferencias",
                newName: "IdTransferencia");

            migrationBuilder.RenameIndex(
                name: "IX_Transferencias_IdSenderUser",
                table: "Transferencias",
                newName: "IX_Transferencias_IdUsuarioRemetente");

            migrationBuilder.RenameIndex(
                name: "IX_Transferencias_IdRecipientUser",
                table: "Transferencias",
                newName: "IX_Transferencias_IdUsuarioDestinatario");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TiposUsuario",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Contas",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "Contas",
                newName: "Saldo");

            migrationBuilder.RenameColumn(
                name: "IdAccount",
                table: "Contas",
                newName: "IdConta");

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Usuarios_IdUsuarioDestinatario",
                table: "Transferencias",
                column: "IdUsuarioDestinatario",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transferencias_Usuarios_IdUsuarioRemetente",
                table: "Transferencias",
                column: "IdUsuarioRemetente",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Contas_IdConta",
                table: "Usuarios",
                column: "IdConta",
                principalTable: "Contas",
                principalColumn: "IdConta",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_TiposUsuario_IdTipoUsuario",
                table: "Usuarios",
                column: "IdTipoUsuario",
                principalTable: "TiposUsuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
