﻿using Businesss.Concrete;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using Entitiess.Concrete;
using Model.Enums;
using Windows.UI.Abstract.BaseForms;
using Windows.UI.Abstract.Functions;

namespace Windows.UI.Concrete.Forms.FiltreForms
{
    public partial class FiltreEditForm : BaseEditForm
    {
        private readonly KartTuru _filtreKartTuru;
        private readonly GridControl _filtreGrid;

        public FiltreEditForm(params object[] prm)
        {
            InitializeComponent();


            _filtreKartTuru = (KartTuru)prm[0];
            _filtreGrid = (GridControl)prm[1];


            HideItems = new BarItem[] { btnYeni, btnGeriAl };
            ShowItems = new BarItem[] { btnFarkliKaydet, btnUygula };

            DataLayoutControl = myDataLayoutControl;
            Bll = new FiltreManager(myDataLayoutControl);
            BaseKartTuru = KartTuru.Filtre;
            Eventsload();
        }

        protected internal override void Yukle()
        {
            txtFiltreMetni.SourceControl = _filtreGrid;

            while (true)
            {
                if (BaseIslemTuru == IslemTuru.EntityInsert)
                {
                    OldEntity = new Filtre();
                    Id = BaseIslemTuru.IdOlustur(OldEntity);
                    txtKod.Text = ((FiltreManager)Bll).YeniKodVer(x => x.KartTuru == _filtreKartTuru);

                }
                else
                {
                    OldEntity = ((FiltreManager)Bll).Single(FilterFunctions.filter<Filtre>(Id));
                    if (OldEntity == null)
                    {
                        BaseIslemTuru = IslemTuru.EntityInsert;
                        continue;
                    }

                    NesneyiKontrollereBagla();
                }
                break;
            }
        }

        protected override void NesneyiKontrollereBagla()
        {
            var entity = (Filtre)OldEntity;

            txtKod.Text = entity.Kod;
            txtFiltreAdi.Text = entity.FiltreAdi;
            txtFiltreMetni.FilterString = entity.FiltreMetni;

        }

        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Filtre
            {
                Id = Id,
                Kod = txtKod.Text,
                FiltreAdi = txtFiltreAdi.Text,
                FiltreMetni = txtFiltreMetni.FilterString,
                KartTuru = _filtreKartTuru

            };

            ButonEnabledDurum();
        }

        protected override bool EntityInsert()
        {
            return ((FiltreManager)Bll).Insert(CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }
        protected override bool EntityUpdate()
        {
            return ((FiltreManager)Bll).Update(OldEntity, CurrentEntity, x => x.Kod == CurrentEntity.Kod && x.KartTuru == _filtreKartTuru);
        }

        protected override void FiltreUygula()
        {
            txtFiltreMetni.Select();
            txtFiltreMetni.ApplyFilter();
        }
        protected internal override void ButonEnabledDurum()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledDurum(btnKaydet, btnFarkliKaydet, btnSil, BaseIslemTuru, OldEntity, CurrentEntity);
        }

    }
}