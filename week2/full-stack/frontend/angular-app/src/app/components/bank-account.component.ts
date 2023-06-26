import { Component, signal } from "@angular/core";
import { CurrencyPipe } from "@angular/common";

@Component({
    selector: 'app-account',
    template: `
        <section>
            <span>Your balance is {{balance() | currency}}</span>
        </section>
        <section>
            <label>Amount: <input type="number" #amount /></label>
        </section>
        <section>
            <button (click)="deposit(amount)">Deposit</button>
            <button (click)="withdraw(amount)">Withdraw</button>
        </section>
    `,
    imports: [CurrencyPipe],
    standalone: true
})
export class BankAccountComponent {



    balance = signal(5000);

    current = 0;
    constructor() {

    }


    deposit(amount: HTMLInputElement) {
        this.balance.set(this.balance() + amount.valueAsNumber);
        amount.value = '';
        amount.focus();
    }



    withdraw(amount: HTMLInputElement) {
        this.balance.set(this.balance() - amount.valueAsNumber);
        amount.value = '';
        amount.focus();
    }
}