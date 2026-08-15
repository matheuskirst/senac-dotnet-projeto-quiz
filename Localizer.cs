using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp
{
    public class AntdUIBrLocalizer : AntdUI.ILocalization
    {
        public string GetLocalizedString(string key)
        {
            return key switch
            {
                "ID" => "pt-BR",

                "MonthFormat" => "MMM",
                "YearFormat" => "yyyy",

                "ToDay" => "Hoje",
                "OK" => "OK",
                "Cancel" => "Cancelar",
                "Now" => "Agora",
                "Clear" => "Limpar",
                "NoData" => "Nenhum dado",

                "Sun" => "Dom",
                "Mon" => "Seg",
                "Tue" => "Ter",
                "Wed" => "Qua",
                "Thu" => "Qui",
                "Fri" => "Sex",
                "Sat" => "Sáb",

                _ => key
            };
        }
    }
}
