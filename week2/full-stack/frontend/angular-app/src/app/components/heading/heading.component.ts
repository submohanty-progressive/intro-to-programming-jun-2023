import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BankAccountComponent } from '../bank-account.component';

@Component({
  selector: 'app-heading',
  standalone: true,
  imports: [CommonModule, BankAccountComponent],
  templateUrl: './heading.component.html',
  styleUrls: ['./heading.component.css']
})
export class HeadingComponent {

}
