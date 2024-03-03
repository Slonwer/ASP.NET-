using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class ExeculteNonQuery : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        if (!IsPostBack) {
            // O código dentro deste bloco será executado apenas na primeira carga da página,
            // evitando execuções repetidas durante postbacks.
        }
    }
}
