using System;
using System.Collections.Generic;
using System.Text;

namespace BulkInsert
{
    public class PedidoMestre
    {
        public PedidoMestre()
        {
            ClienteID = 12333;
            ProdutoID = 321;


            //bRecep = true;
            //bBaca = true;
            //NumReentrega = 1;
            //StatusExporta = 1;



            Tipo = 1;
            Documento = "teste";
            UFID = 1;
            FilialID = 1;
            CDID = 1;
            AreaID = 1;
            RotaID = 1;
            CidadeID = 1;
            BairroID = 1;
            PrecoID = 1;
            ImpostoID = 1;



            RemRazaoSocial = "teste";
            RemEndereco = "teste";
            RemBairro = "teste";
            RemMunicipio = "teste";


            RemUF = "MG";
            RemCEP = "38400156";
            RemCGC = "teste";
            RemInscEstadual = "teste";
            RemInscMunicipal = "teste";

            RemCidadeID = 1;
            DesRazaoSocial = "teste";
            DesEndereco = "teste";
            DesBairro = "teste";
            DesMunicipio = "teste";
            DesUF = "MG";
            DesCEP = "38400156";
            DesCGC = "teste";
            DesInscEstadual = "teste";
            DesInscMunicipal = "teste";
            DesCidadeID = 1;
            DtEntrada = DateTime.Now;
            DtEmissao = DateTime.Now;
            CondFrete = 's';

            Coleta = 1;
            NatOper = "teste";
            CFOP = "teste";

            Natureza = "teste";
            FretePeso = 1;
            FreteValor = 1;
            PesoInicial = 1;
            Aliquota = 1;
            SecCat = "teste";
            Despacho = 1;
            Pedagio = 1;
            Outro = 1;
            TotalPrestacao = 1;
            BaseCalculo = 1;
            AliquotaICMS = 1;
            ICMS = 1;
            Obs = "teste";
            NumCG = 1;
            DtEntrega1 = DateTime.Now;
            DtEntrega2 = DateTime.Now;
            DtEntrega3 = DateTime.Now;
            UltData = DateTime.Now;
            Desistencia = 1;
            Atualizacao = 1;
            Status1 = 1;
            Status2 = 1;
            Status3 = 1;
            Receptor1 = "teste";
            Receptor2 = "teste";
            Receptor3 = "teste";
            ComentarioEntrega = "teste";
            Status = 1;
            DtCancela = DateTime.Now;
            MotivoCancela = 'B';
            NumFatura = 1;
            Outro1 = "teste";
            Outro2 = "teste";
            Outro3 = "teste";
            Tentativa = 1;
            Usuario = "teste";
            UsuFilial = 1;
            AdValorem = 1;
            UsuAltera = "teste";
            ValorEntrega = 1;
            LoteID = 1;
            RGRecep1 = "teste";
            RGRecep2 = "teste";
            RGRecep3 = "teste";
            UsuBaixa1 = "teste";
            UsuBaixa2 = "teste";
            UsuBaixa3 = "teste";
            StatusRecep = 1;
            DtExporta = DateTime.Now;
            UsuLocal = "teste";
            DtLocal = DateTime.Now;
            FilialBaixa = 1;
            LoteBaixaID = 1;
            bRecep = true;
            TipoServ = 1;
            FatAgenteID = 1;
            LoteRecepID = 1;
            bBaca = true;
            DtRecep = DateTime.Now;
            UsuRecep = "teste";
            FilialRecep = 1;
            AgenteID = 1;
            DtImpressao = DateTime.Now;
            BxAgenteID = 1;
            NumReentrega = 1;
            Parentesco = "teste";
            DtUltBaixa = DateTime.Now;
            UsuUltBaixa = "teste";
            DtCobranca = DateTime.Now;
            obs1 = "teste";
            obs2 = "teste";
            obs3 = "teste";
            UsuCancela = "teste";
            StatusOri = 1;
            AgeCancela = "teste";
            numArEBCT = "teste";
            DesFantasia = "teste";
            DtAtuBaixa1 = DateTime.Now;
            DtAtuBaixa2 = DateTime.Now;
            DtAtuBaixa3 = DateTime.Now;
            StatusExporta = 1;
            IdParentesco = 1;
            DtEntregaPrevista = DateTime.Now;
            SLA = 1;
            SLA_Realizado = 1;
            DtEntrega_Texlog = DateTime.Now;
            SLA_Texlog = 1;
            SLA_Realizado_Texlog = 1;
            Dt_Entrega_PrevCliente = DateTime.Now;
            Dt_Entrega_PrevClienteFinal = DateTime.Now;
            BaixaPrazo = 1;
            //nCTR = ???; timestamp
            dtEntrega1Ajuste = DateTime.Now;
            dtEntrega2Ajuste = DateTime.Now;
            dtEntrega3Ajuste = DateTime.Now;
            SLA_RealizadoAjuste = 1;
            UsuarioAjusteSla = "teste";
            dataAjusteSla = DateTime.Now;



        }

        public int ClienteID { get; set; }
        public int ProdutoID { get; set; }

        //public Boolean bRecep { get; set; }
        //public Boolean bBaca { get; set; }
        //public Int16 NumReentrega { get; set; }
        //public Byte StatusExporta { get; set; }




        public Byte Tipo { get; set; }
        public string Documento { get; set; }
        public int UFID { get; set; }
        public int FilialID { get; set; }
        public int CDID { get; set; }
        public int AreaID { get; set; }
        public int RotaID { get; set; }
        public int CidadeID { get; set; }
        public int BairroID { get; set; }
        public int PrecoID { get; set; }
        public int ImpostoID { get; set; }


        public string RemRazaoSocial { get; set; }
        public string RemEndereco { get; set; }
        public string RemBairro { get; set; }
        public string RemMunicipio { get; set; }

        public string RemUF { get; set; }
        public string RemCEP { get; set; }
        public string RemCGC { get; set; }
        public string RemInscEstadual { get; set; }
        public string RemInscMunicipal { get; set; }


        public int RemCidadeID { get; set; }
        public string DesRazaoSocial { get; set; }
        public string DesEndereco { get; set; }
        public string DesBairro { get; set; }
        public string DesMunicipio { get; set; }
        public string DesUF { get; set; }
        public string DesCEP { get; set; }
        public string DesCGC { get; set; }
        public string DesInscEstadual { get; set; }
        public string DesInscMunicipal { get; set; }
        public int DesCidadeID { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtEmissao { get; set; }
        public char CondFrete { get; set; }

        public Byte Coleta { get; set; }
        public string NatOper { get; set; }
        public string CFOP { get; set; }
        public string Natureza { get; set; }

        public double FretePeso { get; set; }
        public double FreteValor { get; set; }
        public double PesoInicial { get; set; }
        public double Aliquota { get; set; }
        public string SecCat { get; set; }
        public double Despacho { get; set; }
        public double Pedagio { get; set; }
        public double Outro { get; set; }
        public double TotalPrestacao { get; set; }
        public double BaseCalculo { get; set; }
        public double AliquotaICMS { get; set; }
        public double ICMS { get; set; }

        public string Obs { get; set; }
        public int NumCG { get; set; }
        public DateTime DtEntrega1 { get; set; }
        public DateTime DtEntrega2 { get; set; }
        public DateTime DtEntrega3 { get; set; }
        public DateTime UltData { get; set; }

        public Byte Desistencia { get; set; }
        public Byte Atualizacao { get; set; }
        public Byte Status1 { get; set; }
        public Byte Status2 { get; set; }
        public Byte Status3 { get; set; }
        public string Receptor1 { get; set; }
        public string Receptor2 { get; set; }
        public string Receptor3 { get; set; }
        public string ComentarioEntrega { get; set; }
        public int Status { get; set; }
        public DateTime DtCancela { get; set; }
        public char MotivoCancela { get; set; }
        public int NumFatura { get; set; }
        public string Outro1 { get; set; }
        public string Outro2 { get; set; }
        public string Outro3 { get; set; }
        public Byte Tentativa { get; set; }
        public string Usuario { get; set; }
        public int UsuFilial { get; set; }
        public double AdValorem { get; set; }
        public string UsuAltera { get; set; }
        public double ValorEntrega { get; set; }
        public int LoteID { get; set; }
        public string RGRecep1 { get; set; }
        public string RGRecep2 { get; set; }
        public string RGRecep3 { get; set; }
        public string UsuBaixa1 { get; set; }
        public string UsuBaixa2 { get; set; }
        public string UsuBaixa3 { get; set; }
        public Byte StatusRecep { get; set; }
        public DateTime DtExporta { get; set; }
        public string UsuLocal { get; set; }
        public DateTime DtLocal { get; set; }
        public int FilialBaixa { get; set; }
        public int LoteBaixaID { get; set; }
        public Boolean bRecep { get; set; }

        public Byte TipoServ { get; set; }
        public int FatAgenteID { get; set; }
        public int LoteRecepID { get; set; }
        public Boolean bBaca { get; set; }
        public DateTime DtRecep { get; set; }
        public string UsuRecep { get; set; }
        public int FilialRecep { get; set; }
        public int AgenteID { get; set; }
        public DateTime DtImpressao { get; set; }
        public int BxAgenteID { get; set; }
        public Byte NumReentrega { get; set; }
        public string Parentesco { get; set; }
        public DateTime DtUltBaixa { get; set; }
        public string UsuUltBaixa { get; set; }
        public DateTime DtCobranca { get; set; }
        public string obs1 { get; set; }
        public string obs2 { get; set; }
        public string obs3 { get; set; }
        public string UsuCancela { get; set; }
        public int StatusOri { get; set; }
        public string AgeCancela { get; set; }
        public string numArEBCT { get; set; }
        public string DesFantasia { get; set; }
        public DateTime DtAtuBaixa1 { get; set; }
        public DateTime DtAtuBaixa2 { get; set; }
        public DateTime DtAtuBaixa3 { get; set; }
        public Byte StatusExporta { get; set; }
        public int IdParentesco { get; set; }
        public DateTime DtEntregaPrevista { get; set; }
        public int SLA { get; set; }
        public int SLA_Realizado { get; set; }
        public DateTime DtEntrega_Texlog { get; set; }
        public int SLA_Texlog { get; set; }
        public int SLA_Realizado_Texlog { get; set; }
        public DateTime Dt_Entrega_PrevCliente { get; set; }
        public DateTime Dt_Entrega_PrevClienteFinal { get; set; }
        public int BaixaPrazo { get; set; }
        //public ????? nCTR { get; set; } timestamp
        public DateTime dtEntrega1Ajuste { get; set; }
        public DateTime dtEntrega2Ajuste { get; set; }
        public DateTime dtEntrega3Ajuste { get; set; }
        public int SLA_RealizadoAjuste { get; set; }
        public string UsuarioAjusteSla { get; set; }
        public DateTime dataAjusteSla { get; set; }




    }
}
