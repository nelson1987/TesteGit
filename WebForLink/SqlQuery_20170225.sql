﻿CREATE TABLE [dbo].[WFL_APLICACAO] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    [Descricao] [varchar](255),
    CONSTRAINT [PK_dbo.WFL_APLICACAO] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[WFL_USUARIO] (
    [Id] [int] NOT NULL IDENTITY,
    [Login] [varchar](150) NOT NULL,
    [Aplicacao_Id] [int],
    [Contratante_Id] [int],
    [Contratante_Id1] [int],
    CONSTRAINT [PK_dbo.WFL_USUARIO] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Contratante] (
    [Id] [int] NOT NULL IDENTITY,
    [RazaoSocial] [varchar](255),
    [Documento] [varchar](255),
    [Criador_Id] [int],
    [TipoEmpresa_Id] [int],
    [DadosGerais_Id] [int],
    [TipoContratante_Id] [int],
    CONSTRAINT [PK_dbo.Contratante] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[ConfiguracaoSistema] (
    [Id] [int] NOT NULL IDENTITY,
    [CaminhoArquivo] [varchar](255),
    [Contratante_Id] [int],
    CONSTRAINT [PK_dbo.ConfiguracaoSistema] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Empresa] (
    [Id] [int] NOT NULL IDENTITY,
    [RazaoSocial] [varchar](255),
    [Documento] [varchar](255),
    [Discriminator] [nvarchar](128) NOT NULL,
    [Robos_Id] [int],
    [Status_Id] [int],
    [Tipo_Id] [int],
    CONSTRAINT [PK_dbo.Empresa] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Documento] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    [Empresa_Id] [int],
    CONSTRAINT [PK_dbo.Documento] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Arquivo] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    [Tipo] [varchar](255),
    [Upload] [datetime] NOT NULL,
    [Tamanho] [int] NOT NULL,
    [Caminho] [varchar](255),
    [Documento_Id] [int],
    CONSTRAINT [PK_dbo.Arquivo] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Banco] (
    [Id] [int] NOT NULL IDENTITY,
    [Codigo] [varchar](255),
    [Nome] [varchar](255),
    [Empresa_Id] [int],
    CONSTRAINT [PK_dbo.Banco] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Contato] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    [Email] [varchar](255),
    [Telefone] [varchar](255),
    [Celular] [varchar](255),
    [Empresa_Id] [int],
    CONSTRAINT [PK_dbo.Contato] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Endereco] (
    [Id] [int] NOT NULL IDENTITY,
    [RUa] [varchar](255),
    [Empresa_Id] [int],
    CONSTRAINT [PK_dbo.Endereco] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Robo] (
    [Id] [int] NOT NULL IDENTITY,
    [RoboReceitaFederal_NomeFantasia] [varchar](255),
    CONSTRAINT [PK_dbo.Robo] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[StatusEmpresa] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    CONSTRAINT [PK_dbo.StatusEmpresa] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[TipoEmpresa] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    CONSTRAINT [PK_dbo.TipoEmpresa] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[TipoContratante] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    CONSTRAINT [PK_dbo.TipoContratante] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Solicitacao] (
    [Id] [int] NOT NULL IDENTITY,
    [Discriminator] [nvarchar](128) NOT NULL,
    [Criador_Id] [int],
    [Solicitado_Id] [int],
    [Tipo_Id] [int],
    CONSTRAINT [PK_dbo.Solicitacao] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[TipoSolicitacao] (
    [Id] [int] NOT NULL IDENTITY,
    [Descricao] [varchar](255),
    [Fluxo_Id] [int],
    CONSTRAINT [PK_dbo.TipoSolicitacao] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Fluxo] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    [Contratante_Id] [int],
    [TipoEmpresa_Id] [int],
    [TipoFluxo_Id] [int],
    CONSTRAINT [PK_dbo.Fluxo] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Etapa] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    [Aprovado] [bit] NOT NULL,
    [Fluxo_Id] [int],
    CONSTRAINT [PK_dbo.Etapa] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[Passo] (
    [Id] [int] NOT NULL IDENTITY,
    [Descricao] [varchar](255),
    [Etapa_Id] [int],
    CONSTRAINT [PK_dbo.Passo] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[TipoFluxo] (
    [Id] [int] NOT NULL IDENTITY,
    [Nome] [varchar](255),
    CONSTRAINT [PK_dbo.TipoFluxo] PRIMARY KEY ([Id])
)
CREATE TABLE [dbo].[EmpresaContratante] (
    [Empresa_Id] [int] NOT NULL,
    [Contratante_Id] [int] NOT NULL,
    CONSTRAINT [PK_dbo.EmpresaContratante] PRIMARY KEY ([Empresa_Id], [Contratante_Id])
)
CREATE INDEX [IX_Aplicacao_Id] ON [dbo].[WFL_USUARIO]([Aplicacao_Id])
CREATE INDEX [IX_Contratante_Id] ON [dbo].[WFL_USUARIO]([Contratante_Id])
CREATE INDEX [IX_Contratante_Id1] ON [dbo].[WFL_USUARIO]([Contratante_Id1])
CREATE INDEX [IX_Criador_Id] ON [dbo].[Contratante]([Criador_Id])
CREATE INDEX [IX_TipoEmpresa_Id] ON [dbo].[Contratante]([TipoEmpresa_Id])
CREATE INDEX [IX_DadosGerais_Id] ON [dbo].[Contratante]([DadosGerais_Id])
CREATE INDEX [IX_TipoContratante_Id] ON [dbo].[Contratante]([TipoContratante_Id])
CREATE INDEX [IX_Contratante_Id] ON [dbo].[ConfiguracaoSistema]([Contratante_Id])
CREATE INDEX [IX_Robos_Id] ON [dbo].[Empresa]([Robos_Id])
CREATE INDEX [IX_Status_Id] ON [dbo].[Empresa]([Status_Id])
CREATE INDEX [IX_Tipo_Id] ON [dbo].[Empresa]([Tipo_Id])
CREATE INDEX [IX_Empresa_Id] ON [dbo].[Documento]([Empresa_Id])
CREATE INDEX [IX_Documento_Id] ON [dbo].[Arquivo]([Documento_Id])
CREATE INDEX [IX_Empresa_Id] ON [dbo].[Banco]([Empresa_Id])
CREATE INDEX [IX_Empresa_Id] ON [dbo].[Contato]([Empresa_Id])
CREATE INDEX [IX_Empresa_Id] ON [dbo].[Endereco]([Empresa_Id])
CREATE INDEX [IX_Criador_Id] ON [dbo].[Solicitacao]([Criador_Id])
CREATE INDEX [IX_Solicitado_Id] ON [dbo].[Solicitacao]([Solicitado_Id])
CREATE INDEX [IX_Tipo_Id] ON [dbo].[Solicitacao]([Tipo_Id])
CREATE INDEX [IX_Fluxo_Id] ON [dbo].[TipoSolicitacao]([Fluxo_Id])
CREATE INDEX [IX_Contratante_Id] ON [dbo].[Fluxo]([Contratante_Id])
CREATE INDEX [IX_TipoEmpresa_Id] ON [dbo].[Fluxo]([TipoEmpresa_Id])
CREATE INDEX [IX_TipoFluxo_Id] ON [dbo].[Fluxo]([TipoFluxo_Id])
CREATE INDEX [IX_Fluxo_Id] ON [dbo].[Etapa]([Fluxo_Id])
CREATE INDEX [IX_Etapa_Id] ON [dbo].[Passo]([Etapa_Id])
CREATE INDEX [IX_Empresa_Id] ON [dbo].[EmpresaContratante]([Empresa_Id])
CREATE INDEX [IX_Contratante_Id] ON [dbo].[EmpresaContratante]([Contratante_Id])
ALTER TABLE [dbo].[WFL_USUARIO] ADD CONSTRAINT [FK_dbo.WFL_USUARIO_dbo.WFL_APLICACAO_Aplicacao_Id] FOREIGN KEY ([Aplicacao_Id]) REFERENCES [dbo].[WFL_APLICACAO] ([Id])
ALTER TABLE [dbo].[WFL_USUARIO] ADD CONSTRAINT [FK_dbo.WFL_USUARIO_dbo.Contratante_Contratante_Id] FOREIGN KEY ([Contratante_Id]) REFERENCES [dbo].[Contratante] ([Id])
ALTER TABLE [dbo].[WFL_USUARIO] ADD CONSTRAINT [FK_dbo.WFL_USUARIO_dbo.Contratante_Contratante_Id1] FOREIGN KEY ([Contratante_Id1]) REFERENCES [dbo].[Contratante] ([Id])
ALTER TABLE [dbo].[Contratante] ADD CONSTRAINT [FK_dbo.Contratante_dbo.WFL_USUARIO_Criador_Id] FOREIGN KEY ([Criador_Id]) REFERENCES [dbo].[WFL_USUARIO] ([Id])
ALTER TABLE [dbo].[Contratante] ADD CONSTRAINT [FK_dbo.Contratante_dbo.TipoEmpresa_TipoEmpresa_Id] FOREIGN KEY ([TipoEmpresa_Id]) REFERENCES [dbo].[TipoEmpresa] ([Id])
ALTER TABLE [dbo].[Contratante] ADD CONSTRAINT [FK_dbo.Contratante_dbo.Empresa_DadosGerais_Id] FOREIGN KEY ([DadosGerais_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[Contratante] ADD CONSTRAINT [FK_dbo.Contratante_dbo.TipoContratante_TipoContratante_Id] FOREIGN KEY ([TipoContratante_Id]) REFERENCES [dbo].[TipoContratante] ([Id])
ALTER TABLE [dbo].[ConfiguracaoSistema] ADD CONSTRAINT [FK_dbo.ConfiguracaoSistema_dbo.Contratante_Contratante_Id] FOREIGN KEY ([Contratante_Id]) REFERENCES [dbo].[Contratante] ([Id])
ALTER TABLE [dbo].[Empresa] ADD CONSTRAINT [FK_dbo.Empresa_dbo.Robo_Robos_Id] FOREIGN KEY ([Robos_Id]) REFERENCES [dbo].[Robo] ([Id])
ALTER TABLE [dbo].[Empresa] ADD CONSTRAINT [FK_dbo.Empresa_dbo.StatusEmpresa_Status_Id] FOREIGN KEY ([Status_Id]) REFERENCES [dbo].[StatusEmpresa] ([Id])
ALTER TABLE [dbo].[Empresa] ADD CONSTRAINT [FK_dbo.Empresa_dbo.TipoEmpresa_Tipo_Id] FOREIGN KEY ([Tipo_Id]) REFERENCES [dbo].[TipoEmpresa] ([Id])
ALTER TABLE [dbo].[Documento] ADD CONSTRAINT [FK_dbo.Documento_dbo.Empresa_Empresa_Id] FOREIGN KEY ([Empresa_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[Arquivo] ADD CONSTRAINT [FK_dbo.Arquivo_dbo.Documento_Documento_Id] FOREIGN KEY ([Documento_Id]) REFERENCES [dbo].[Documento] ([Id])
ALTER TABLE [dbo].[Banco] ADD CONSTRAINT [FK_dbo.Banco_dbo.Empresa_Empresa_Id] FOREIGN KEY ([Empresa_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[Contato] ADD CONSTRAINT [FK_dbo.Contato_dbo.Empresa_Empresa_Id] FOREIGN KEY ([Empresa_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[Endereco] ADD CONSTRAINT [FK_dbo.Endereco_dbo.Empresa_Empresa_Id] FOREIGN KEY ([Empresa_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[Solicitacao] ADD CONSTRAINT [FK_dbo.Solicitacao_dbo.WFL_USUARIO_Criador_Id] FOREIGN KEY ([Criador_Id]) REFERENCES [dbo].[WFL_USUARIO] ([Id])
ALTER TABLE [dbo].[Solicitacao] ADD CONSTRAINT [FK_dbo.Solicitacao_dbo.Empresa_Solicitado_Id] FOREIGN KEY ([Solicitado_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[Solicitacao] ADD CONSTRAINT [FK_dbo.Solicitacao_dbo.TipoSolicitacao_Tipo_Id] FOREIGN KEY ([Tipo_Id]) REFERENCES [dbo].[TipoSolicitacao] ([Id])
ALTER TABLE [dbo].[TipoSolicitacao] ADD CONSTRAINT [FK_dbo.TipoSolicitacao_dbo.Fluxo_Fluxo_Id] FOREIGN KEY ([Fluxo_Id]) REFERENCES [dbo].[Fluxo] ([Id])
ALTER TABLE [dbo].[Fluxo] ADD CONSTRAINT [FK_dbo.Fluxo_dbo.Contratante_Contratante_Id] FOREIGN KEY ([Contratante_Id]) REFERENCES [dbo].[Contratante] ([Id])
ALTER TABLE [dbo].[Fluxo] ADD CONSTRAINT [FK_dbo.Fluxo_dbo.TipoEmpresa_TipoEmpresa_Id] FOREIGN KEY ([TipoEmpresa_Id]) REFERENCES [dbo].[TipoEmpresa] ([Id])
ALTER TABLE [dbo].[Fluxo] ADD CONSTRAINT [FK_dbo.Fluxo_dbo.TipoFluxo_TipoFluxo_Id] FOREIGN KEY ([TipoFluxo_Id]) REFERENCES [dbo].[TipoFluxo] ([Id])
ALTER TABLE [dbo].[Etapa] ADD CONSTRAINT [FK_dbo.Etapa_dbo.Fluxo_Fluxo_Id] FOREIGN KEY ([Fluxo_Id]) REFERENCES [dbo].[Fluxo] ([Id])
ALTER TABLE [dbo].[Passo] ADD CONSTRAINT [FK_dbo.Passo_dbo.Etapa_Etapa_Id] FOREIGN KEY ([Etapa_Id]) REFERENCES [dbo].[Etapa] ([Id])
ALTER TABLE [dbo].[EmpresaContratante] ADD CONSTRAINT [FK_dbo.EmpresaContratante_dbo.Empresa_Empresa_Id] FOREIGN KEY ([Empresa_Id]) REFERENCES [dbo].[Empresa] ([Id])
ALTER TABLE [dbo].[EmpresaContratante] ADD CONSTRAINT [FK_dbo.EmpresaContratante_dbo.Contratante_Contratante_Id] FOREIGN KEY ([Contratante_Id]) REFERENCES [dbo].[Contratante] ([Id])
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201702251348069_AutomaticMigration', N'WebForLink.Win.Migrations.Configuration',  0x1F8B0800000000000400ED5DDD6EE33A92BE5F60DFC1F0D5EE414F9CF44103338D640639E9CE41309DEE46DC3967EF02C56612E1D89247921BC92EF6C9F6621E695E61F54349FCA9E29F2859EE18B98945B2485615C922F9B1EA5FFFF7CFD3BF3DAF5793EF2449C3383A9B9E1C1D4F27245AC4CB307A3C9B6EB3873FFD79FAB7BFFEFBBF9D7E5CAE9F27BFD5F97E2EF2E525A3F46CFA94659BF7B359BA7822EB203D5A878B244EE387EC6811AF67C1329EBD3D3EFECBECE464467212D39CD664727AB38DB2704DCA1FF9CF8B385A904DB60D56D7F192AC52FA3D4F999754279F83354937C1829C4D7F27F79771F2298CFE38FA3D8C8EF2A21979CEE2E9E47C15067973E664F5309D04511467419637F6FD6D4AE65912478FF34DFE21587D7BD9903CDF43B04A09EDC4FB36BB697F8EDF16FD99B5056B528B6D9AC56B4B82273F5306CDC4E24E6C9E360C2C99BBDEACC873D1ED928F67D39BF83EBE88938484713A9D8835BEBF582545668ED51FF21C39B73FE662CB42921EB124DE4CA48C6F1A55393E2AFFDE4C2EB6AB6C9B90B3886CB32458BD997CDDDEAFC2C5DFC9CBB7F80F129D45DBD56A3A99E95B7E431624CC824BB224399D0EEDE70979EC05D387BC175F93784392EC8576E173BC269741940569184C27554373FDCCC7DB74721D3C7F22D163F674367DFBEEDD7472193E9365FD852AEC6D14E6C3332F94255B22306CC6704CCFC879587C4D3F078BBC8B9D3829501A5821E6613E053C2641A70E5424866EF9F62109D69D1A5E51E8ADDD65652F4CB3CF3779896011C48E8D6ECAF736DEF234EE0333046FC803EDC6D592EF683178C482E2C82DCA54FDBB8AB29FDF4E279FF3CA83FB1569C626C38B791627E45712E5534B46965F832C234954D0202547A5DA8159C2F3EC2057F281A48B242C65E9BBA6CFC1F7F0B1E48450E76DBA0D9272DDB921AB3243FA146EAA65FB8826DE314A7699C4EB9B78D5966C13EFBE05C923C9F2C6C7588E79BC4D16D22CD92AB552D529394745A7A50F6AAEAAEB53FC18460AED3B79776CA47D52134DD591D1B4EEFA586B1BAE8FB5C69A36AFB06E73CEE6E602513690CB27379149461BC9E6819A693C6CB8B6380D1D86C261F8A8EABA09FE3B88E7F1222CACB7BE178B78B15DE7CD1A72B1C815E1217CDC26C5D899876956EC7CC0710064C4C68426ABB4A8E8F2434B8CB24F4998EFD612AC1B0DDD261FD77431591ACE501EDB59E7435E2AFD35D7C910E576530797176E2A9345D95C369F6D933FAE37094983F4225806694E7189280ACDC74A906B37942EA90498C9560FBE859B5837BD0B79D056ABF249AD576676E9056507DA031DCFB13C60CBBDF05E6984B2BC6933C2AA5DA72BF5BAC9D4755915E721F7E555A474586655755D04EB307A8ACF937F6CC3EF03AF7FCAF9C1E3B20728B0D132E9A6CBAB9074300FABD23ECF3C7E095242A5CAAC12BAB310C62472EA4853FE30FC863F0BC1B784D5308717079A78C788BE1D6352A2B482C9396C972ED5625BAF8DE711798E41B3A64A410D1A9ADCE9D4A49925DD8E07ABD28701B1F3C3C1C2D8EABD92DBCD2A0E1ACE7DC8B9F12D5C1B9CE7886D0D723D7B8A7512305AE5079C699849A4FB54232EE0F864E434AC9B79C76958D3D28761FD9A4F73EA65A9CBCA256A39B2B09936E997205A689A5467919B54A5A04DA2C92E47BE41A6D89BE68977CD68E4B7A54C12748EC5A55B9F5B71BB775F472B18F3C07300631B295A9284A082A5A91013C534D9521233D8B2B1B8B455F38FE690195726A01CAB526D5935CF75620BB7A74AAAC9D7076C6CC3E01C12CF906C2E474D4AC6551964BE15DF51B695899D56C6729C3BAE8B65D9C3AAA834CBE265F8D8BF25DA834D6D756316389F22D0D2072DDAF996E963CEF4FE4DB76F64451EE2A8FFEE5C90D5761524035A88AAC30D0BD3073A8C874C23B78D10B5005C7742B4F861B82AB742B7BEB191CE676A36D6A2646460E6A493E615165E07A8E041E3941A07208B991B0128D9F27C89475D0BB4DB0407AA129057202EA53BD551836C25E275820BD51A002B12ADBF2B691A8F1C6E07E23884381A87B134A20B9B766BEA73172BCEE59ACDAE935E72E80927AD64281C7472443AA93D2DEB048C1175538BA071D2CECBE0BE4087BB5FD4B704767F579F571EE5EB7789A873EB4C4360F79D91B063CE73C7016ABBC7F347676820348F6871846E16589C2B496E3CBB3F1C62281C34B53BD498612704350692658B08C8637DFF40692CE1A37DB60A362BDCD03687B2AD4C36DBE6A277102C7DF11E424C5336AEFB7D4441A1FB7013A81C869CF2367D070FE92E57DB67581705D1DDD19CFC9A20650017033957378BB26A899BFD55943DA8E1386D14500F2B8541F0C852A2A47F720E6B1C40166C9063818A789D416C56F51D69114D74593A5407CD7478B1B9C466B1DB3CB86D6C0E9706E2934A4B5F9A4E842445D33C4C2125F72DA790A2C861E6D8F9F5E8F92689BF97E65B55D12F71AE1E41D4E1F5EED7204D31344D21F4BB3A037367C37C97EF6BD8C44E6A5AD2705CE9CAB2077DDD85C165656477B1669AF207398F159523D8BFF465A9A7FD544DADC7B3446E0FC871E03C9F5F1661D976FE4124E3E88017CBC76839D17A3D68AB6E3C675CE70D0F37653B5ECEA63F49E256D16D60842D5DC60F034FF9F8E8E8441433D34B75E775AFE8B0261B3FA96B3B003EE2346792F1DB75AEC6D6FCF6CB34E9A9BAA2D9F8BB75A3A66A9882BE78D7EB642726C84F34B0462ADE6B30EA5D3F9D32EFBCE2C9594B9701FB7BECBC80D9C75A8801F8814B0F5DE354746DBAFD53E73ED34701BAB6892F047CF559785AC0D0A560645FFD154177AA310822F0F8D11D6865A1A40AF4D7988F0E42E6AE54742281EF55B40D55755FED13C165DEB46182887B435B8982E098CE3798498BDEA34F3186917EF50C43271BE14D861779F32F39046494D7BE22E018AC813AA40C637BF2802BAB494EF7AAC496C716FC404119585BF5088DB6B5DCD19E1547F40E52FA9E0CD817363AF5E5AFB8BC8C08EE52CC95A58EC62DEBE0C8C40405BD1D793572213F496C0DB5730D8F0C51A20D546AAB871EF0D2B4DAAE98D736D440017D0799C8547624E4B885D3D760BE3772E703E49750B7F3D76C9D3B9C29EC688B0C412CD0454F85B740CE74CC19A1426AF4BC4546101C262D85E01C5E590100417A362EE52B51AC9D8AFBD1B689F404DABCF7F89DEA00E381BB9241977CF07E86914A75FF67B76D86AE75189AF4B2C6D7E4C7DD2DAB25215E346B44ABE927783FADE35DD77EB23698BA61E0F575676586AEBC073011C5FB707D2385CB712F1DE72FD4856E1BAA90A51928238B5416990266C437D6713A578394ECC793E3CAA6DC18E1F83FAFAB996A93A4206FC183EA8AAC3C950B2392503EB4175834160B7043769B127A4996D23B39B14705E539C91AA84073D1D3DECBC99740125F782A8D3D23D168523414B8A550A2C2A5EA2901AE8C2192F20591867473CE4D208ACC29B8860EBD4B00A93457131A1AED032B8904F8B60120511E61838DA087DB06320B10663487D0BA6ED0C34790487B9AA9A1529CD78114AA833C4D69EE1C0CA2221CB269C8310B21448C5B270D48F1EF0D407236C3839BA0E49E6257D948E398FC58E36C48966B07D84DBAAAE8B489C20C654DAA0C324DF1D23C05ABA786AB0147F02E30968240875905A439950D89C0E4E3A7570C4E60082868FAC1CCE4331B42F562C810C2178F19DF5D035668BDEFCA8CB1821A38810D98BEC24B8E8283A6F002BE0E748C3B7154F67F0F72518D3D30461F98F5C4186EA0D75807A6007E20659668900886580476A0B4C680821938FC8021C5D9279DD921BA0A9479A1022698401398A6B70BA682090812A1770ED49E09710E40300513A0822B07045C0243A631EABCCC119C1F20787E40510B46B805615E0820C91941150C38D9410378230CD703FCBAC61CCBE0AA13E03D4C6F2B88ECAE07E08A12DA60066E60B9C1EC1554FCC0F00CFDAA08F52689EB06807330403AB86A038F6D60A8D47BA5CE1DC71C7EC81C30413FD8E01F98DE887B3705673470877EB403F73E21B3C90C1461078B607AC5EF4B158CD2A220FA9B543807A3F850924F01F50009D781C49DF619B2B3A345CE857A525BE52868C20A36D1D13A877012FD0D27DC19033CA4CCE014F6800A4117F8A6688697163F31C8CEAF0DBAA456321860610EB1E8A85E12A0A297DD1F18E1113F71313B4C50412E1C4F5D063D27009D57000BBC0E80610CC1609776FCE0D01873D18BA660BE32D47CC1301936A88C8EDC016018FD4CD3C0837499391A8886214883E94073F4AA60078ECBE8CFA8E11EC802460D8AD6D0E33558F1D1B36F954903C1331812CDF9B72705A89B84C91E426EE8B11B4E1217B01A5ABE39F799BBDEC13A8E42390CC11C4E2C80F01BFDD9B3921B03152F00788311B6C3990F3C7A41E00242CAD15C051CC4C076AA06EF6181F810FAC35FD2692C531CE3A16776C7B514DBF5A9F11F6608908E2BA76A13A862AF8223F5F3E806E5D1A49DCEE68B27B20EE887D3599E654136D936585DC74BB24AEB84EB60B309A3C7B42D49BF4CE69B605158D17F9A4F27CFEB55949E4D9FB26CF37E364B4BD2E9D13A5C24711A3F64478B783DCB4D82D9DBE3E3BFCC4E4E66EB8AC66CC1CDCC2226A5A9298B93E09108A965340972192669F6215F48EF83E2ADF8C5722D6593312DC8156B5D9F085B91E5575FBBD6258AFF4500CDD1EF6174446B8C8F506A2D472FF34E16170B657F0978CF2995CD4BCF17C12A488077FD17F16ABB8E30DF00AAD2D54B7DB67CF5C59C02E3D38125C37C96699DCE0446887C9F498C17068228492339D746BB0F2923B40C648C96EC47C29FE2C730E209D04FA3918BDA6AB7978D829E817C94A5FB911117428E25C325588CC9F6CE991B9318A66CB7B297D10E9E944082E43929839E4A3F4A2186AF66298969A311A7E23AC64184F4499CBDD890ED900751E58D5B86259CF8B760B5254C506C6EA485C5EA97CB28C88A332EFFE2D170F42A2DFEFFF2F01F186B2983FE7354BCFD61E74647FD673CB98F494CD210603DCE8F6914A07C6D9DCA8F9BAF8CF3FB7DE02BCA9A3131B5394E1B94A38ECB298B40F32121146768202345D95DEF4D77249D166CE9E5DC801A730EA70658C95DCB05A3509DCDB114AA2FE614EA08F42C8DFA9B453BEA00F45C53EA8FD6A63A68A38F485F6B34A70F6DAD1EF5D8EB2A52AEA72D140D42CB89857EFB81E6A116EBEAEBF424705A21D092639D8768E4579604FD64318734715DB949A4F96AA1AD75E0564E5DEB8FA3D1360638EBC568AC9FE539588D68D19EB6A2B782D9587E188D602816D78750CA978EF602818B79B0E18B4098CF86A13FF53D134A0155AAA69CCB7CA31BA4A1A80A12DD3B3E33D8B399D0B5B1A8920084F6A152FCB3577BDDD294DFF512B3234171380B1F625280490C84A42CFD8A45A4410ABB89A9DB359796C22B15170BE8F07AE4CE1076397657B4ABABAC76745C28C05D1A4FFDA3E20D748488357C2F0E6995BC1A1BA73974D53E1CD84A10AE1E068AE364DFAFE8F61D1B548310BDDC2F41784B032921E55EE9428CE2B91DCE184A872D0E070C70B95D0B04A3D046EA62A9B45F4723DAFA69800FD956CE74EC658B947BF513218B59F7B578B94E888AB2BB1E837D4B87477AF322029C39190356D94286C8D402C52E5EBF614E9B643E1949A9A503C9ABE0D5123922336A1CC5ED3B36CEBA49AD197B951651D69AF866A65D1681FED61AA2F571E5849FE4493840250161193AAF72141D4BC98366197AF31A959EA959E043D364DF5F5610EDB69805121B160EE6E1CB557B28153F9A8379331B97B6A05DEEAC2980433463500C5BC810FD020801757BE62882968E070D41DDBB8D4A3F545DEEAC21A28F3863C46153C218B3060800762BE7C8FD9A9807C580FDD48D4A2BF0DE7AD389DA6B9EB94ED4258C10480ABEF34EF6C6A30FBCD7BED7A20F921F416340535BC410B7842CE380BFC0DD2B05E211F1B56805EC14CD7CAEE0CB21E8743B7354E5486DF7FAA2F2C836F85EABBBF825F791E6B8337C5AC0E065103B112F91231034E20AF3B5CD0CD4A1A6F994400B18BE54510C31CE77A623DB2B1A1EC73DE7167454BA8075B5B326601E462DA16B4C4977DD50BB2475944745D48796A89D9B8E4A5DD04E77D617DCD9AA158A4E635BD819153A0FAD8EA261C97A501F9DCBD7512990BAEFDED69FEA8193F9F253E5EFBEFAB0BE863A6887CFB58775A5343A55E8FB8C9CF3C66B774ECE15F577560EF8DB753D0F6528793E3307FC0C8F4A75D45DF7B2167157080EEB115EBEFB9A84D1F6B02E79BEC233F1973C2ACDD2F3C0EBFCD47A71B69B9CDA72EEA802885E470DF27F018C3A921E95D6F4AC31A07B6B730C8A1247608F42E90B2F2005EDB5D61785C7EE11AB8B1CACB8F3DE1BF2FC6D8555C75102EA071BD2D616F7EFEDAA33FE50020A5FE6E35297FE5002983B743B65614BFAD317D9E3B9EB494D4BC8B3D6C86EDE47A538CA8E77D61DC051BC21585FBD22A1FE93051EA2EEE0C761BCA06EEF47A5223D5B2EBCFF7CC3A7034D7E23103974F401B8DB77BD1B2A49F9388E01FCF78F4A13B09E7A9A276A57FDA653449DDFE891083AFCF8F0038EFCAE48799B12F87006A3D201ACA79E74808BAF60AA085CA16E6B051045611C47F868B488516947CF67F752D4091B0DA145BAEB071737A18376789E34A4F819A3D38CDEE60E241087F543DE3B444734AF7591534D34D6C6AE171965789151694D6F1A230726B1DBCFC2B781EE3BD911DD0A62415646A518CE3783525C16314BF38E907E697E377159684C142E584BC98D22F44AC98594C6671183A45459A693BCEBDFC365112065FE523C5A3A2A321CCDFFB1AA7C97B719AE83287C2069F62DFE834467D3B7C7276FA793F35518A455F01C1AFEE5FD629B66F13A88A238A3A1750CE2C19CFC5CC48321CBF54C2C6E1F55A6A092A64BCE7717F33AB57E5201475339FD3B91B4A0D68E1BF230C114E97426163C0594B1A8FF6C1A166C2DC7EBAF24977A9091E5D720CB481215B948D9D2E9A4D0B7E0BE080F44756EA6245FBD45AD2AF81E248BA7C22FE075F0FC89448FD9532EAF77EF589A59B2D592645E2077A0CB3E76554A043CDBDF5B79D0382A38E34EDE1D5B13E5DF8532AD1747CDFBAB68499ECFA6FF53167C3FB9FAAF3BB6EC9BC997241FD2EF27C793FFB5D50AF10CC6AE157C697FED38E9D69013F39618EB337A53BEB73ACD4555F03BD5F0EFFEBCD1652F232CF5A329D94549C54DA85D1BF8D25DDA214250ECDAC197EECA8F6E13884CA19FA1AB7EAEBEB743580C0EE477B4ED646930962A0890DC5B49EEDF642CF865AB6847A06DF4F6CFF6FC68DE06D8A95D5DAECBB4C600CDED2A6F0A769D541D67D27E061AF2B27A6F875A0F7B2B77A3C0C52030961CE82FE120377EAC7926598726A9882EF3AE6761D16ECBCE36A1491886BA19077D2D272E962753B60775079EFBEFADB2D7B14BBCCAEEF5CC7CE03BFFBD55865EE456063FF13B9B369150FCEE43EAB828AF4171E197E87BABB965D894D72037391ECAFECA4C17DF6488EB03450C90BD656CE769DC987B68708E03EF8C78F7E31DF60FC73F14AAB0B7BCEBF7A46BD7971A0250DFF2C48B2DFC439D7A299159FBABCA5E400032DD164E6527BFBA5C0F0204E0977B2BB61E368063B9F81FCB9D2A0F23B56F458F9A0C3C3B3868320BA3A9A35E5464EF43FBB3D211CE5FC083A3BD957A5FCB4EFB6EC8F2288096EBC96E382C3D4ED39CC6F7A6190B952F63E4ECBA37883AEEF7791C657851D0FF3A0E3404932A8392AE2FC4A468247C7F3E46CBC94DBC222C8897F6A200221F315FAFB7AB2CDC9436F9CBD9F4F8E848765FD052AB01A82CADE61B4FE927894CAE202429464CB0CA5994E63C0AE5B82F5F93305A849B6025B55FC86938D60BAE3634C5940F6443A262100BDD33A94A1773A5A12D28BF8E0B1C285EAD059A781AA84E484FBCA924B9EF567A01A1C104CA727A2FFAA270BED487C668617048B5FAB7E9C3E88F1445C4C3C8D7EB8AADF679D20D9BE1DD5D2FACD450ED0565005D90238560F293B06FA5F498AF56DA20C02CABD5A9FED68B16A0412DFAD00324BA0A58952E1ECA005A200404C184C6BDF9A6426BBE5989DF52993CA9001EA1DDBB02D8699BFA09FA800A40A37FF4AF0015BE88A543BFECBBE0C13829E314BA10FD6200A9D7502271FD0F7E84210FE2A4C62A7B6377D86E7AA05202E06C02A0D8BF5938A06AE843A1EC9196400FE0BBD9F9FBA02D036F301D356614FB4B29464CFF0B4B03F5E348351FF77EFE4062EA8C7BD6A862C160222B517EACB8AA0F76623757204F4297B1893D49DC42B954616E06103712E70593198F46642527A48C5C1314A8CADDAB8432A8CD003A814672C1E427B994A332E4BEEFC979238A18ED472F6C6D04BDCFBB01D788F2D5D8704A31FC3431B032D854A5F04535F02D041BA365985388DDCC0C239E15F45168065A36B8DB29D3A50313A994B6278AA204CE8F4361CCA2CC0C3C9134F1543C8A7474D8888115C3E6FA74140A01C54B39E8C308F4018C0C33C40E150888E2417C1A45605F3C70DB5CF6FBBE031E14CE546185D835E0018977D2BFD5B93B7518D0EAB455076D48970134420E6532DC62C1F8C0A6B4E8971F61A1009DB68FD76CE06296A0F341F97E849B0DAA2F5662AFDE23B054E8977EC63F146AA30F8183715DC08A54E158061BF2343449C7B1A93B713253184FA2361F725DCF998C754AE5107F3051E38FF8FB3C6D1C76761FF8A4D15CD54671E02C86185169812C37E6EBC83560B019C04EFE3B9E05E01022FDCEFCE2AB77519FFA37FC07D3054DE89531AE0B529C901EC438DA1DA18BBC06DE190E7939F5910F36D26C4A84C020928AD09032E2CBB0E9A47DCF273FBCABC28B9C4D9725FCA57A14F8FBE5A7BBF3AF9FAE2ECE2FCEBF001AC357D41C4749D534295825B7F3DBF39B2B7D15DC8E56AA864B85AAE232E8AB92DF884155CAB990AAE58C9A2634D69D546D1BB00EA8AA49D490679E354815306950154CB2A692E6F18CAC7B750A544193A8214FD1F91271FA1D224D930C342D0059D3A4601A1618B0A5C500CAB26D9240E136A99A1A2AD89A44BDFA0C51AE523454052C94445E4887EA11B2682AE4763952757CF046A0322E834155EA0946CA81556933D170CBAACC50361564279BC1A087EAEAA41C580F6DAAA556AA54591D300FA88226E946517564210FA1EA3B387EAA240D617AEC2511A6DF21C234C94002183B98348CEB866C01C0E7D812A25567289F503F1F360DF5093061F2F18601E63880334B253BA68C9AC77C952C32E0F68C29D97C137A23448133E82AB0B6F321C8E58EEB8AE05D01A45A76472120B13C66D7D474B4868A138BA4B7DD305BD44FC05DA5DA95850E5D969F30031DD6BC73E69A2DD96B65A351538C1F3CBC19560D1DC4C6B2EFAAF04E17E8A7EA252F7F2ECDAFF5554C6E7801EFC29C0E9DA46F51159D845EAB7AE92467ED96A56063D66D7CB26F2E91B1893ECBF4D23DC1E66EC6246450BBCB0F7A5AA810A6F625A297AEE34B364BC2EF04A57A4567CA1038EAACC7E56A278C111F8A41DC503E26F3A313C21EB12A88EDFFDCE55FBD8752481C7830C53594DD6A968D84B692AE2C71E818F2F207E8A1C91B21FE6C14DAFF56E19B55DBDA013B8F3E7101BA6FF61C06BF8D643AA0D868EFC0F6E29E7128345B3E61F7DAD97E258DBD54D0D8D5E8A3066F6B78FFF25502F211453703F04BF2C73AA439E6D9015340C0B946196060BAD715BCDFBD3704AA561C340CB3C7EEB7CB106C185ADB74E8622F7B69E038B15A0E15E783DDBACCA06335BDC670B45E26BA613A2E8340813E6B90A25E559B3BBC2C4BC267920E6B368B7384D66C1407C9CB933D13AEA4091DF97265B8E3DEB20C7C9AEB2A3F8AE843450721FE5CB8EEC208E74E714610D63305F8CBA39DD59F528AF02C6547415C0B8CE1123AA997667F5D8431488811A5012B75565AE486AA61547FCB0AB6555003727C35BEC7A5A576E3DCE0489AB4D35975E1433FE43FB338091EC975BC24ABB4FC7A3ABBD9464574D3EAD70792868F2D89D39C6644161C6EA5C973153DC4357E4668519D45F0737D4DF2B53A5F83CE932C7C0816599EBC20691A468FD3C96FC16A5BAED6F76479157DD9669B6D967799ACEF572F2C330A188EAAFED399D4E6D32F9BE257EAA30B7933C32220EC97E8976DB85A36EDBE04DC6B23240A7C0F75EE5EC8B25895C9E34B43E973197DD18410655F034BFA46D69B554E2CFD12CD83EFC4A56DB729F9441E83C54BFEFD7BB824094E442F089EEDA71FC2E03109D629A5D196CF7FE63ABC5C3FFFF5FF0169BB45C72C770100 , N'6.1.3-40302')

