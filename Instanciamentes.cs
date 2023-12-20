using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Karesz
{
	partial class Form1
	{
		#region Robotokra visszavezetett parancsok
		/// <summary>
		/// Lép és lerak n alkalommal, paraméter nélkül egyszer
		/// </summary>
		/// <param name="n"></param>
		/// <param name="c"></param>
		void ElőreRakj(int n = 1, int c = fekete) =>
			Robot.akit_kiválasztottak.ElőreRakj(n, c);
		/// <summary>
		/// Nem fogy a köve
		/// </summary>
		/// <param name="n"></param>
		void Végtelenkő(bool n = true) =>
			Robot.akit_kiválasztottak.Végtelen_kő(n);
		/// <summary>
		/// Előre megy n alkalommal, paraméter nélkül egyszer
		/// </summary>
		/// <param name="n"></param>
		void Előre(int n = 1) =>
			Robot.akit_kiválasztottak.Előre(n);
		void Jobbra(int n = 1) =>
			Robot.akit_kiválasztottak.Fordulj(jobbra, n);
		void Balra(int n = 1) =>
			Robot.akit_kiválasztottak.Fordulj(balra, n);
		int Köveinek_száma_ebből(int szín) => 
			Robot.akit_kiválasztottak.Köveinek_száma_ebből(szín);
		void Vegyél_fel_egy_kavicsot() => 
			Robot.akit_kiválasztottak.Vegyél_fel_egy_kavicsot();
		void Tegyél_le_egy_kavicsot(int szín = fekete) => 
			Robot.akit_kiválasztottak.Tegyél_le_egy_kavicsot(szín);
		bool Van_e_itt_Kavics() => 
			Robot.akit_kiválasztottak.Alatt_van_kavics();
		int Mi_van_alattam() => 
			Robot.akit_kiválasztottak.Alatt_ez_van();
		bool Van_e_előttem_fal() =>
			Robot.akit_kiválasztottak.Előtt_fal_van();
		bool Kilépek_e_a_pályáról() =>
			Robot.akit_kiválasztottak.Ki_fog_lépni_a_pályáról();
		int Ultrahang() => 
			Robot.akit_kiválasztottak.UltrahangSzenzor();
		int Hőmérséklet() => 
			Robot.akit_kiválasztottak.Hőmérő();

        #endregion

        #region Pályára visszavezetett parancsok

        void Betölt(string path) => pálya.Betölt(path);

        #endregion
	}
}
