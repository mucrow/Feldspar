function main() {
  const parts = [
    { name: "helmet", portion: 1 },
    { name: "gloves", portion: 1 },
    { name: "boots", portion: 2 },
    { name: "torso", portion: 5 },
    { name: "pants", portion: 5 },
  ];

  const totalWeight = 26800;
  // const totalMaxDurability = 1890;
  const totalMaxDurability = 200;

  const whole = parts.reduce((acc, curr) => acc + curr.portion, 0);
  const partWeights = [];
  const partMaxDurabilities = [];
  for (const part of parts) {
    const partFraction = part.portion / whole;

    const partWeight = partFraction * totalWeight;
    const partWeightFmt = partWeight.toFixed(2).padStart(8) + 'g';
    partWeights.push(partWeight);

    const partMaxDurability = partFraction * totalMaxDurability;
    const partMaxDurabilityFmt = partMaxDurability.toFixed(2).padStart(7) + ' durability';
    partMaxDurabilities.push(partMaxDurability);

    console.log([part.name.padEnd(6), partWeightFmt, partMaxDurabilityFmt].join('     '));
  }

  let totalWeightRecalc = 0;
  const roundedPartWeights = [];
  for (const weight of partWeights) {
    const rounded = Math.round(weight);
    roundedPartWeights.push(rounded);
    totalWeightRecalc += rounded;
  }
  console.log(`\n${roundedPartWeights.join(' + ')} = ${totalWeightRecalc}g`);

  let totalMaxDurabilityRecalc = 0;
  const roundedPartMaxDurabilities = [];
  for (const maxDurability of partMaxDurabilities) {
    const rounded = Math.round(maxDurability);
    roundedPartMaxDurabilities.push(rounded);
    totalMaxDurabilityRecalc += rounded;
  }
  console.log(`\n${roundedPartMaxDurabilities.join(' + ')} = ${totalMaxDurabilityRecalc} durability`);
}

main();
