﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletMover : ManejoPallets {

    public MoveType miInput;
    public enum MoveType {
        WASD,
        Arrows
    }

    public ManejoPallets Desde, Hasta;
    bool segundoCompleto = false;

    private void Update() {
        switch (miInput) {
            case MoveType.WASD:
                if (!Tenencia() && Desde.Tenencia() && InputManager.Instance.GetAxis("Horizontal_1") < 0) {
                    PrimerPaso();
                }
                if (Tenencia() && InputManager.Instance.GetAxis("Vertical_1") > 0) {
                    SegundoPaso();
                }
                if (segundoCompleto && Tenencia() && InputManager.Instance.GetAxis("Horizontal_1") > 0) {
                    TercerPaso();
                }
                break;
            case MoveType.Arrows:
                if (!Tenencia() && Desde.Tenencia() && InputManager.Instance.GetAxis("Horizontal_2") < 0) {
                    PrimerPaso();
                }
                if (Tenencia() && InputManager.Instance.GetAxis("Vertical_2") > 0) {
                    SegundoPaso();
                }
                if (segundoCompleto && Tenencia() && InputManager.Instance.GetAxis("Horizontal_2") > 0) {
                    TercerPaso();
                }
                break;
            default:
                break;
        }
    }

    void PrimerPaso() {
        Desde.Dar(this);
        segundoCompleto = false;
    }
    void SegundoPaso() {
        base.Pallets[0].transform.position = transform.position;
        segundoCompleto = true;
    }
    void TercerPaso() {
        Dar(Hasta);
        segundoCompleto = false;
    }

    public override void Dar(ManejoPallets receptor) {
        if (Tenencia()) {
            if (receptor.Recibir(Pallets[0])) {
                Pallets.RemoveAt(0);
            }
        }
    }
    public override bool Recibir(Pallet pallet) {
        if (!Tenencia()) {
            pallet.Portador = this.gameObject;
            base.Recibir(pallet);
            return true;
        }
        else
            return false;
    }
}
