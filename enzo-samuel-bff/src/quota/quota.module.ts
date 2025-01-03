import { Module } from '@nestjs/common';
import { QuotaResolver } from './quota.resolver';
import { QuotaService } from './quota.service';

@Module({
  providers: [QuotaResolver, QuotaService],
})
export class QuotaModule {}
