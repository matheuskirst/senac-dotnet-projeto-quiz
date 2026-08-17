using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenacQuizApp
{
    public class AntdUIEnLocalizer : AntdUI.ILocalization
    {
        public string GetLocalizedString(string key)
        {
            return key switch
            {
                "ID" => "en-US",

                "MonthFormat" => "MMM",
                "YearFormat" => "yyyy",

                "ToDay" => "Today",
                "OK" => "OK",
                "Cancel" => "Cancel",
                "Now" => "Now",
                "Clear" => "Limpar",
                "NoData" => "No Data",

                "Sun" => "Sun",
                "Mon" => "Mon",
                "Tue" => "Tue",
                "Wed" => "Wed",
                "Thu" => "Thu",
                "Fri" => "Fri",
                "Sat" => "Sat",

                _ => key
            };
        }
    }

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
