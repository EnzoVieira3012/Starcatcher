import { Module } from '@nestjs/common';
import { ConsortiumService } from './consortium.service';
import { ConsortiumResolver } from './consortium.resolver';

@Module({
  providers: [ConsortiumService, ConsortiumResolver],
})
export class ConsortiumModule {}
